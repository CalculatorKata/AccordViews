using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using XmlAttributeExtractor;
using System.Xml;

namespace XmlAttributeDiplayer
{
    class Program
    {
        static void Main(string[] args)
        {
            var extractor = new XmlExtractor(File.ReadAllText(@"A_Lion_1952-10-27_OMUL.xml"));


            XmlNodeList holdings = extractor.ExtractNodes("Holding");
            foreach (XmlNode holding in holdings)
            {
                
                var HoldingName = extractor.ExtractString("HoldingName", holding.ChildNodes);
                var HoldingTypeCode = extractor.ExtractString("HoldingTypeCode", holding.ChildNodes);
                var CurrencyTypeCode = extractor.ExtractString("CurrencyTypeCode", holding.ChildNodes);

                XmlNodeList policys = extractor.ExtractNodes("Policy", holding);
                foreach (XmlNode policy in policys)
                {
                    var PolNumber = extractor.ExtractString("PolNumber", policy.ChildNodes);
                    var LineOfBusiness = extractor.ExtractString("LineOfBusiness", policy.ChildNodes);
                    var ProductType = extractor.ExtractString("ProductType", policy.ChildNodes);
                    var PolicyStatus = extractor.ExtractString("PolicyStatus", policy.ChildNodes);
                    var EffDate = extractor.ExtractString("EffDate", policy.ChildNodes);
                    var TermDate = extractor.ExtractString("TermDate", policy.ChildNodes);

                    XmlNodeList Lifes = extractor.ExtractNodes("Life", policy);
                    foreach (XmlNode life in Lifes)
                    {
                        var CashValueAmt = extractor.ExtractString("CashValueAmt", life.ChildNodes);
                        var DeathBenefitAmt = extractor.ExtractString("DeathBenefitAmt", life.ChildNodes);

                        XmlNodeList Coverages = extractor.ExtractNodes("Coverage", life);
                        foreach (XmlNode Coverage in Coverages)
                        {
                            var PlanName = extractor.ExtractString("PlanName", Coverage.ChildNodes);
                            var ProductCode = extractor.ExtractString("ProductCode", Coverage.ChildNodes);
                            var LifeCovStatus = extractor.ExtractString("LifeCovStatus", Coverage.ChildNodes);
                            var LifeCovTypeCode = extractor.ExtractString("LifeCovTypeCode", Coverage.ChildNodes);
                            var IndicatorCode = extractor.ExtractString("IndicatorCode", Coverage.ChildNodes);
                            var CashValue = extractor.ExtractString("CashValue", Coverage.ChildNodes);
                            var CoverageEffDate = extractor.ExtractString("EffDate", Coverage.ChildNodes);
                            var CoverageTermDate = extractor.ExtractString("TermDate", Coverage.ChildNodes);
                        }

                    }
                }

                XmlNodeList Investments = extractor.ExtractNodes("Investment", holding);
                foreach (XmlNode Investment in Investments)
                {
                    var AcctNum = extractor.ExtractString("AcctNum", Investment.ChildNodes);
                    var AcctOpenDate = extractor.ExtractString("AcctOpenDate", Investment.ChildNodes);
                    var CarrierCode = extractor.ExtractString("CarrierCode", Investment.ChildNodes);
                    var AccountValue = extractor.ExtractString("AccountValue", Investment.ChildNodes);

                    XmlNodeList SubAccounts = extractor.ExtractNodes("SubAccount", Investment);
                    foreach (XmlNode SubAccount in SubAccounts)
                    {
                        var SubAccountCarrierCode = extractor.ExtractString("CarrierCode", SubAccount.ChildNodes);
                        var ProductFullName = extractor.ExtractString("ProductFullName", SubAccount.ChildNodes);
                        var PortfolioFullName = extractor.ExtractString("PortfolioFullName", SubAccount.ChildNodes);
                        var AsOfDate = extractor.ExtractString("AsOfDate", SubAccount.ChildNodes);
                        var CurrNumberUnits = extractor.ExtractString("CurrNumberUnits", SubAccount.ChildNodes);
                        var UnitValue = extractor.ExtractString("UnitValue", SubAccount.ChildNodes);
                        var TotValue = extractor.ExtractString("TotValue", SubAccount.ChildNodes);
                        var AllocPercent = extractor.ExtractString("AllocPercent", SubAccount.ChildNodes);

                    }
                }

            }
        }
    }
}
