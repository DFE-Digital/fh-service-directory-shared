using FamilyHubs.ServiceDirectory.Shared.Models;
using Xunit;

namespace FamilyHubs.ServiceDirectory.Shared.UnitTests
{
    public class ResultTests
    {
        [Fact]
        public void SuccessMethod_BuildsSuccessfulResult()
        {
            //  Arrange / Act
            var result = Result.Success();

            //  Assert
            Assert.True(result.Succeeded);
            Assert.Empty(result.Errors);
        }

        [Fact]
        public void SuccessMethod_BuildsSuccessfulResultWithValue()
        {
            //  Arrange
            var testObject = new TestObject("Hello World");

            //  Act
            var result = Result<TestObject>.Success(testObject);

            //  Assert
            Assert.True(result.Succeeded);
            Assert.Empty(result.Errors);
            Assert.Equal("Hello World", result.Value!.SomeProp);
        }

        [Fact]
        public void SuccessMethod_BuildsFailureResult()
        {
            //  Arrange
            var errors = new List<string> { "Hello World" };

            //  Act
            var result = Result.Failure(errors);

            //  Assert
            Assert.False(result.Succeeded);
            Assert.Equal("Hello World", result.Errors[0]);
        }

        [Fact]
        public void SuccessMethod_BuildsFailureResultForValueResult()
        {
            //  Arrange
            var errors = new List<string> { "Hello World" , "Hello World 2" };

            //  Act
            var result = Result<TestObject>.Failure("testFailure", errors);

            //  Assert
            Assert.False(result.Succeeded);
            Assert.Equal("Hello World", result.Errors[0]);
            Assert.Equal("Hello World 2", result.Errors[1]);
            Assert.Equal("testFailure", result.FailureType);
            Assert.Null(result.Value);
        }

        [Fact]
        public void SuccessMethod_BuildsFailureResultForValueResult_WithSingleError()
        {
            //  Arrange
            var error = "Hello World" ;

            //  Act
            var result = Result<TestObject>.Failure("testFailure", error);

            //  Assert
            Assert.False(result.Succeeded);
            Assert.Equal("Hello World", result.Errors[0]);
            Assert.Equal("testFailure", result.FailureType);
            Assert.Null(result.Value);
        }
    }

    public class TestObject
    {
        public string SomeProp { get; set; }

        public TestObject(string someProp)
        {
            SomeProp = someProp;
        }
    }
}
