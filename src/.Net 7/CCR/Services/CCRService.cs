using pt.portugal.eid;

namespace CCR.Services
{
    public class CCRService : ICCRService
    {

        private PTEID_PDFSignature signature;

        public CCRService()
        {
            signature = new PTEID_PDFSignature();
        }


        public void Sign(Models.File file)
        {
            var cardReader = new CardReader();

            var s1 = cardReader.Read();

            signature.setSignatureLevel(PTEID_SignatureLevel.PTEID_LEVEL_BASIC);
            var s = signature.getCertificateCitizenName();





        }

        public void Sign(Models.File[] files)
        {
            foreach (var file in files)
            {
                //signature.addToBatchSigning()
            }
        } 
    }
}
