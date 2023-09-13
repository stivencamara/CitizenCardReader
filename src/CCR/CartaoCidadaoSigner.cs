using pt.portugal.eid;

namespace CCR
{
    public class CartaoCidadaoSigner
    {
        public PTEID_ReaderContext context;

        private PTEID_EIDCard GetInstance()
        {
            PTEID_ReaderSet pTEID_ReaderSet = PTEID_ReaderSet.instance();
            context = pTEID_ReaderSet.getReader();
            return context.getEIDCard();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unsignedPath"></param>
        /// <param name="signedPath"></param>
        /// <param name="x">0 to 1</param>
        /// <param name="y">0 to 1</param>
        /// <param name="page"></param>
        /// <param name="location"></param>
        /// <param name="reason"></param>
        /// <param name="indexTimestampServer">Default -1. 0 to 4</param>
        /// <param name="enableSmallSignatureFormat">Default true</param>
        public void Sign(string unsignedPath, string signedPath, int page, double x, double y, string location = "",
            string reason = "", int indexTimestampServer = -1, bool enableSmallSignatureFormat = true)
        {
            using (var card = GetInstance())
            {
                ConfigTimestampServer(indexTimestampServer);
                sign(new string[1] { unsignedPath }, signedPath, x, y, page, location, reason, enableSmallSignatureFormat, card);
            }
        }

        public void Sign(string unsignedPath, string signedPath, int page, int sector, string location = "",
            string reason = "", int indexTimestampServer = -1, bool enableSmallSignatureFormat = true)
        {
            using (var card = GetInstance())
            {
                ConfigTimestampServer(indexTimestampServer);
                sign(new string[1] { unsignedPath }, signedPath, 0, 0, page, location, reason, enableSmallSignatureFormat, card, sector);
            }
        }

        public void Sign(string[] unsignedPaths, string outputSignedPath, int page, double x, double y, string location = "",
            string reason = "", int indexTimestampServer = -1, bool enableSmallSignatureFormat = true)
        {
            using (var card = GetInstance())
            {
                ConfigTimestampServer(indexTimestampServer);
                sign(unsignedPaths, outputSignedPath, x, y, page, location, reason, enableSmallSignatureFormat, card);
            }
        }

        public void Sign(string[] unsignedPaths, string outputSignedPath, int page, int sector, string location = "",
            string reason = "", int indexTimestampServer = -1, bool enableSmallSignatureFormat = true)
        {
            using (var card = GetInstance())
            {
                ConfigTimestampServer(indexTimestampServer);
                sign(unsignedPaths, outputSignedPath, 0, 0, page, location, reason, enableSmallSignatureFormat, card, sector);
            }
        }

        private static void sign(string[] unsignedPaths, string signedPath, double x, double y, int page,
            string location, string reason, bool enableSmallSignatureFormat, PTEID_EIDCard card, int sector = -1)
        {
            using (PTEID_PDFSignature pTEID_PDFSignature = GetPDFSignatureInstance(unsignedPaths))
            {
                if (enableSmallSignatureFormat)
                    pTEID_PDFSignature.enableSmallSignatureFormat();

                pTEID_PDFSignature.enableTimestamp();
                if (sector == -1)
                    card.SignPDF(pTEID_PDFSignature, page, x, y, location, reason, signedPath);
                else
                    
                    card.SignPDF(pTEID_PDFSignature, page, sector, true, location, reason, signedPath);
            }
        }

        private static PTEID_PDFSignature GetPDFSignatureInstance(string[] unsignedPaths)
        {
            if (unsignedPaths.Length == 1)
                return new PTEID_PDFSignature(unsignedPaths[0]);
            else
            {
                var signature = new PTEID_PDFSignature();

                foreach (var unsignedPath in unsignedPaths)
                    signature.addToBatchSigning(unsignedPath);

                return signature;
            }
        }


        private void ConfigTimestampServer(int indexTimestampServer)
        {
            if (indexTimestampServer > -1)
            {
                #region Configure Timestamp

                /*
                 Foi adicionado devido a um erro que ocorrer ao ligar a VPN do cliente.
                 Foi aberto um ticket no projeto da AMAPT no github 
                 https://github.com/amagovpt/autenticacao.gov/issues/54
                 */

                //https://gist.github.com/Manouchehri/fd754e402d98430243455713efada710
                var servers = new string[]
                {
                    "http://timestamp.digicert.com",
                    "http://timestamp.entrust.net/TSS/RFC3161sha2TS",
                    "http://tsa.starfieldtech.com",
                    "http://sha256timestamp.ws.symantec.com/sha256/timestamp",
                    "http://time.certum.pl"
                };

                if (indexTimestampServer > 5)
                    indexTimestampServer = 0;

                PTEID_Config config = new PTEID_Config(PTEID_Param.PTEID_PARAM_XSIGN_TSAURL);
                config.setString(servers[indexTimestampServer]);
                //config.setLong(60);

                #endregion Timestamp
            }
        }

        public void SignStandard(string basicAuthUser, string basicAuthPassword, string applicationId)
        {
            var config = @"C:\Windows\System32\pteidpkcs11.dll";


            //pt.portugal.eid.pteidlib_dotNet

            //Provider p = Security.getProvider("SunPKCS11");
            //p = p.configure(config);
           
            // Security.addProvider(p);

            // Keystore ks = KeyStore.getInstance("PKCS11", p);

            //PTEID_CMDSignatureClient.setCredentials(basicAuthUser, basicAuthPassword, applicationId);

            //PTEID_SigningDeviceFactory factory = PTEID_SigningDeviceFactory.instance();
            //PTEID_SigningDevice signingDev = factory.getSigningDevice(true, true);

            //signingDev.SignXadesTIndividual(dirDestino, ficheiros, ficheiros.length);
        }
    }
}
