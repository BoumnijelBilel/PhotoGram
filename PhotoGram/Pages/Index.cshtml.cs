using CorePhotoGram.Interfaces;
using PhotoGram.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CorePhotoGram.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<UploadedImage> Images;

        private readonly IStorageService _storageService;

        public IndexModel(IStorageService storageService)
        {
            _storageService = storageService;
        }

        public async Task OnGetAsync()
        {
            this.Images = await _storageService.GetImagesAsync();
        }

    }
}
