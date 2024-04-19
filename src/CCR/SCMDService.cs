
namespace CCR
{
    public class SCMDService
    {
        public string GetCertificate(byte[] applicationId, string userId)
        {
            ServiceReference.SCMDServiceClient client = new ServiceReference.SCMDServiceClient();

            return client.GetCertificate(applicationId, userId);
        }
    }
}
