namespace Laerdal.Xamarin.FFmpeg
{
    public partial class MediaInformation
    {
        public Laerdal.Xamarin.FFmpeg.iOS.MediaInformation NativeMediaInformation { get; }
        
        public MediaInformation(string path) : base(path) 
        {
            NativeMediaInformation = iOS.MobileFFprobe.GetMediaInformation(path);
        }

        public override string FileName => NativeMediaInformation.Filename;
        
        public override string Bitrate => NativeMediaInformation.Bitrate;
        
        public override string Duration => NativeMediaInformation.Duration;
        
        public override string Format => NativeMediaInformation.Format;
        
        public override string Size => NativeMediaInformation.Size;
        
        public override string LongFormat => NativeMediaInformation.LongFormat;
        
        public override string StartTime => NativeMediaInformation.StartTime;
    }
}