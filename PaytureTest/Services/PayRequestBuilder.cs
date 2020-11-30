using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PaytureTest
{
    public  class PayRequestBuilder
    {
        private  string _request = "https://sandbox3.payture.com/api/Pay?";


        #region Mandatory

        public PayRequestBuilder SetKey(string Key)
        {
            _request += "Key=" + Key + "&";
            return this;
        }

        public PayRequestBuilder SetOrderId(string OrderId)
        {
            _request += "OrderId=" + OrderId + "&";
            return this;
        }

        public PayRequestBuilder SetAmount(string Amount)
        {
            _request += "Amount=" + Amount + "&";
            return this;
        }

        public PayRequestBuilder SetPayInfo(string payInfo)
        {
            _request += "PayInfo=" + payInfo + "&";
            return this;
        }

        #endregion

        #region Optional

        public PayRequestBuilder SetPaytureId( string PaytureId)
        {
            _request += "PaytureId=" + PaytureId + "&";
            return this;
        }

        public PayRequestBuilder SetCustomerKey( string CustomerKey)
        {
            _request += "CustomerKey=" + CustomerKey + "&";
            return this;
        }


        public PayRequestBuilder SetCheque( string Cheque)
        {
            _request += "Cheque=" + Cheque + "&";
            return this;
        }

        #endregion


        public  string Build()
        {
            return _request;
        }
    }

    public class PayInfoBuilder
    {
        private string _payInfo = String.Empty;

        public PayInfoBuilder SetPAN(string PAN)
        {
            _payInfo += HttpUtility.UrlEncode("PAN=" + PAN + ";");
            return this;
        }

        public PayInfoBuilder SetEMonth(int EMonth)
        {
            _payInfo += HttpUtility.UrlEncode("EMonth=" + EMonth + ";");
            return this;
        }

        public PayInfoBuilder SetEYear(int EYear)
        {
            _payInfo += HttpUtility.UrlEncode("EYear=" + EYear + ";");
            return this;
        }

        public PayInfoBuilder SetOrderId(string OrderId)
        {
            _payInfo += HttpUtility.UrlEncode("OrderId=" + OrderId + ";");
            return this;
        }

        public PayInfoBuilder SetAmount(int Amount)
        {
            _payInfo += HttpUtility.UrlEncode("Amount=" + Amount + ";");
            return this;
        }

        public  PayInfoBuilder SetSecureCode(int SecureCode)
        {
            _payInfo += HttpUtility.UrlEncode("SecureCode=" + SecureCode + ";");
            return this;
        }

        public PayInfoBuilder SetCardHolder(string SecureCode)
        {
            _payInfo += HttpUtility.UrlEncode("CardHolder=" + SecureCode + ";");
            return this;
        }

        public  string Build()
        {
            return _payInfo;
        }
    }
}