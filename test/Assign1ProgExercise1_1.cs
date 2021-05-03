using System;
using Xunit;
using System.Text.RegularExpressions;
using System.IO;

namespace csharpassignment
{
    public class Assign1ProgExercise1_1
    {
        [Fact]
        public void ConsoleOutputTest()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            PersonalInfo.Main();

            //parse the output into a string array 
            //then check each index in the array below
            var arrayFromMainMethod = output.ToString().Split("\n");

            //use regex to match console output.
            //test regex at http://regexstorm.net/tester
            Assert.Matches(new Regex(@"\w+[*\s\w+]*"), arrayFromMainMethod[0]);
            Assert.Matches(new Regex(@"(0?[1-9]|1[012])\/(0?[1-9]|[12][0-9]|3[01])\/\d{4}"), arrayFromMainMethod[1]);
            Assert.Matches(new Regex(@"(W|w)ork(\s*|\W)\d{3}-\d{3}-\d{4}"), arrayFromMainMethod[2]);
            Assert.Matches(new Regex(@"(C|c)ell(\s*|\W)\d{3}-\d{3}-\d{4}"), arrayFromMainMethod[3]);

            //clean up
            output.Dispose();
        }
    }
}
