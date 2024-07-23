namespace BarcodeReader
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please scan a barcode:");

            string scannedData = Console.ReadLine();

            if (string.IsNullOrEmpty(scannedData))
            {
                Console.WriteLine("No data scanned.");
                return;
            }

            string processedData = ProcessScannedData(scannedData);

            string filePath = "output.txt";

            WriteToFile(processedData, filePath);

            Console.WriteLine($"Processed data written to {filePath} successfully.");
        }

        static string ProcessScannedData(string data)
        {
            return data.Replace('.', '/').Replace('*', '-');
        }

        static void WriteToFile(string data, string filePath)
        {
            File.WriteAllText(filePath, data);
        }
    }
}
