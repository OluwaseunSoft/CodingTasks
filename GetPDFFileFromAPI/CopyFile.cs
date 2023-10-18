namespace GetPDFFileFromAPI
{
    public class CopyFile
    {
        public static string CopyFileToDirectory(string old)
        {
            try
            {
                Random rnd = new Random();
                int dice = rnd.Next(1, 1000);
                if (!File.Exists(Path.Combine("wwwroot\\", dice.ToString() + Path.GetFileName(old))))
                {
                    File.Copy(old, Path.Combine("wwwroot\\", dice.ToString() + Path.GetFileName(old)));
                }

                return Path.Combine("wwwroot\\", dice.ToString() + Path.GetFileName(old));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }

        }
    }
}
