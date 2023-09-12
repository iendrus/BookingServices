

namespace BookingServices.Application.Common.Helpers
{
    public static class Helpers
    {

        public static string GetFileContent(string filePath)
        {
            try
            {
                string fileContent = File.ReadAllText(filePath);
                return fileContent;
            }
            catch (Exception ex)
            {   
                throw new Exception( "Wystąpił błąd: " + ex.Message);
            }
        }
    }
}
