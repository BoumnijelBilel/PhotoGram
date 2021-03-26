using System;
using System.IO;
using PhotoGram.Common;
using PhotoGram.Model;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace PhotoGram.AzFunctions
{
    public static class ImageUploaded
    {
        [FunctionName("ImageUploaded")]
        public static void Run([BlobTrigger("images/{name}")]Stream inputBlob,
                               [Blob("watermarked/{name}", FileAccess.Write)] Stream outputBlob,
                               string name,
                               ILogger log)
        {
            if (!outputBlob.CanWrite)
            {
                log.LogError($"{Constants.WatermarkedContainer} Blob has no Write access");
                return;
            }
            try
            {
                WaterMarker.Generate(inputBlob, outputBlob);
                log.LogInformation($"Image:{name}, {inputBlob.Length} bytes");
            }
            catch (Exception e)
            {
                log.LogError($"Watermaking failed {e.Message}");
            }
        }
    }

}
