using com.enestekle.Business.Abstract;
using SixLabors.ImageSharp.Formats.Jpeg;

namespace com.enestekle.Business.Concerete
{
    public partial class ImageBusiness : IImage_Service
    {
        public MemoryStream ResizeImage(Stream file)
        {
            Image image = Image.Load(file);
            image.Mutate(x => x.Resize(new Size(image.Width * 2, image.Height * 2), true));

            using (var memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, new JpegEncoder());
                return memoryStream;
            }
        }
    }
}
