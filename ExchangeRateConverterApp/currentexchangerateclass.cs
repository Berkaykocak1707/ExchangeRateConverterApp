using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExchangeRateConverterApp
{
    public class currentexchangerateclass
    {
        public double DolarForexBuying
        {
            get; private set;
        }
        public double DolarForexSelling
        {
            get; private set;
        }

        public double EuroForexBuying
        {
            get; private set;
        }
        public double EuroForexSelling
        {
            get; private set;
        }

        public double SterlinForexBuying
        {
            get; private set;
        }
        public double SterlinForexSelling
        {
            get; private set;
        }

        public double CADForexBuying
        {
            get; private set;
        }
        public double CADForexSelling
        {
            get; private set;
        }

        public double AZNForexBuying
        {
            get; private set;
        }
        public double AZNForexSelling
        {
            get; private set;
        }

        public double AEDForexBuying
        {
            get; private set;
        }
        public double AEDForexSelling
        {
            get; private set;
        }

        public double NOKForexBuying
        {
            get; private set;
        }
        public double NOKForexSelling
        {
            get; private set;
        }

        public double CHFForexBuying
        {
            get; private set;
        }
        public double CHFForexSelling
        {
            get; private set;
        }

        public double SEKForexBuying
        {
            get; private set;
        }
        public double SEKForexSelling
        {
            get; private set;
        }

        public void GetForexData()
        {
            // Address of the web service
            string url = "http://www.tcmb.gov.tr/kurlar/today.xml";

            // Send an HTTP request to retrieve the XML data
            WebClient client = new WebClient();
            string xmlData = client.DownloadString(url);

            // Load the XML data into an XmlDocument object
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlData);

            // Find the Currency node for USD (Dollar)
            XmlNode usdNode = xmlDoc.SelectSingleNode("/Tarih_Date/Currency[@Kod='USD']");

            // Retrieve the Forex Buying and Selling values for USD (Dollar) as double
            DolarForexBuying = Convert.ToDouble(usdNode["ForexBuying"].InnerText, CultureInfo.InvariantCulture);
            DolarForexSelling = Convert.ToDouble(usdNode["ForexSelling"].InnerText, CultureInfo.InvariantCulture);

            // Find the Currency node for EUR (Euro)
            XmlNode eurNode = xmlDoc.SelectSingleNode("/Tarih_Date/Currency[@Kod='EUR']");
            EuroForexBuying = Convert.ToDouble(eurNode["ForexBuying"].InnerText, CultureInfo.InvariantCulture);
            EuroForexSelling = Convert.ToDouble(eurNode["ForexSelling"].InnerText, CultureInfo.InvariantCulture);

            // Find the Currency node for GBP (British Pound)
            XmlNode gbpNode = xmlDoc.SelectSingleNode("/Tarih_Date/Currency[@Kod='GBP']");
            SterlinForexBuying = Convert.ToDouble(gbpNode["ForexBuying"].InnerText, CultureInfo.InvariantCulture);
            SterlinForexSelling = Convert.ToDouble(gbpNode["ForexSelling"].InnerText, CultureInfo.InvariantCulture);

            // Find the Currency node for CAD (Canadian Dollar)
            XmlNode cadNode = xmlDoc.SelectSingleNode("/Tarih_Date/Currency[@Kod='CAD']");
            CADForexBuying = Convert.ToDouble(cadNode["ForexBuying"].InnerText, CultureInfo.InvariantCulture);
            CADForexSelling = Convert.ToDouble(cadNode["ForexSelling"].InnerText, CultureInfo.InvariantCulture);

            // Find the Currency node for AZN (Azerbaijani Manat)
            XmlNode aznNode = xmlDoc.SelectSingleNode("/Tarih_Date/Currency[@Kod='AZN']");
            AZNForexBuying = Convert.ToDouble(aznNode["ForexBuying"].InnerText, CultureInfo.InvariantCulture);
            AZNForexSelling = Convert.ToDouble(aznNode["ForexSelling"].InnerText, CultureInfo.InvariantCulture);

            // Find the Currency node for AED (United Arab Emirates Dirham)
            XmlNode aedNode = xmlDoc.SelectSingleNode("/Tarih_Date/Currency[@Kod='AED']");
            AEDForexBuying = Convert.ToDouble(aedNode["ForexBuying"].InnerText, CultureInfo.InvariantCulture);
            AEDForexSelling = Convert.ToDouble(aedNode["ForexSelling"].InnerText, CultureInfo.InvariantCulture);

            // Find the Currency node for NOK (Norwegian Krone)
            XmlNode nokNode = xmlDoc.SelectSingleNode("/Tarih_Date/Currency[@Kod='NOK']");
            NOKForexBuying = Convert.ToDouble(nokNode["ForexBuying"].InnerText, CultureInfo.InvariantCulture);
            NOKForexSelling = Convert.ToDouble(nokNode["ForexSelling"].InnerText, CultureInfo.InvariantCulture);

            // Find the Currency node for CHF (Swiss Franc)
            XmlNode chfNode = xmlDoc.SelectSingleNode("/Tarih_Date/Currency[@Kod='CHF']");
            CHFForexBuying = Convert.ToDouble(chfNode["ForexBuying"].InnerText, CultureInfo.InvariantCulture);
            CHFForexSelling = Convert.ToDouble(chfNode["ForexSelling"].InnerText, CultureInfo.InvariantCulture);

            // Find the Currency node for SEK (Swedish Krona)
            XmlNode sekNode = xmlDoc.SelectSingleNode("/Tarih_Date/Currency[@Kod='SEK']");
            SEKForexBuying = Convert.ToDouble(sekNode["ForexBuying"].InnerText, CultureInfo.InvariantCulture);
            SEKForexSelling = Convert.ToDouble(sekNode["ForexSelling"].InnerText, CultureInfo.InvariantCulture);

        }
    }
}
