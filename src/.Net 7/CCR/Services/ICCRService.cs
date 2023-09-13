namespace CCR.Services
{
    public interface ICCRService
    {
        void Sign(Models.File file);
        void Sign(Models.File[] files);
    }
}