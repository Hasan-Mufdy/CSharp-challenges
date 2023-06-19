
namespace ChallengesTest
{
    public class UnitTest1
    {
        [Fact]
        public void Product_ReturnProduct()
        {
            int[] nums = { 2, 3, 4 };

            int result = Program.product(nums);

            Assert.Equal(24, result);
        }

        [Fact]
        public void Product_InputMoreThan3()
        {
            int[] nums = { 1, 2, 3, 4 };

            int result = Program.product(nums);

            Assert.Equal(0, result);
        }
        [Fact]
        public void Product_InputLessThan3()
        {
            int[] nums = { 3, 5};

            int result = Program.product(nums);

            Assert.Equal(0, result);
        }

        [Fact]
        public void Average_ReturnsCorrectAverage()
        {
            int[] nums = { 1, 2, 3, 4, 5 };

            double avg = Program.Average(nums);

            Assert.Equal(3, avg);

        }

        [Fact]
        public void Average_ConfirmInput()
        {
            int[] nums = { 10, 10, 10};

            double avg = Program.Average(nums);

            Assert.Equal(10, avg);

        }
        [Fact]
        public void Average_AllZeroInput()
        {
            int[] nums = { 0, 0, 0, 0, 0 };
            
            double avg = Program.Average(nums);


        }

        [Fact]
        public void maxValue_AllIntTheSame()
        {
            int[] nums = { 3, 3, 3, 3, 3 };

            int max = Program.maxValue(nums);

            Assert.Equal(3, max);
        }

        [Fact]
        public void maxValue_HasNegativeValues()
        {
            int[] nums = { -3, -4, -2, -5, -10 };

            int max = Program.maxValue(nums);
            
            Assert.Equal(-2, max);
        
        }

        [Fact]
        public void calculateWords_ReturnsCorrectOutput()
        {
            string[] input = { "This", "is", "a", "sentence" };
            string[] expectedOutput = { "This: 4", "is: 2", "a: 1", "sentence: 8" };

            string[] output = Program.calculateWords(input);

            Assert.Equal(expectedOutput, output);

        }

        [Fact]
        public void calculateWords_ReturnsCorrectOutputIfItHasSymbols()
        {
            string[] input = { "This?", "is#", "a*", "sentence-" };
            string[] expectedOutput = { "This: 5", "is: 3", "a: 2", "sentence: 9" };

            string[] output = Program.calculateWords(input);

            Assert.Equal(expectedOutput, output);

        }



    }

}