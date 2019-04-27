using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"c:\fiel.zip");
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);

                var content = streamReader.ReadToEnd();
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero");
            }
            catch (ArithmeticException ex)
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, an unexpected error occured");
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Dispose();
            }


            try
            {
                using (var streamReader1 = new StreamReader(@"c:\file.zip"))
                {
                    var content = streamReader1.ReadToEnd();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, an unexpected error occured");
            }


            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("artur");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
