using System.Text;

namespace ipdb
{

    public class CityInfo
    {

        private readonly string[] data;

        public CityInfo(string[] data)
        {
            this.data = data;
        }

        public string GetCountryName()
        {
            return data[0];
        }

        public string GetRegionName()
        {
            return data[1];
        }

        public string GetCityName()
        {
            return data[2];
        }

        public string GetOwnerDomain()
        {
            return data[3];
        }

        public string GetIspDomain()
        {
            return data[4];
        }

        public string GetLatitude()
        {
            return data[5];
        }

        public string GetLongitude()
        {
            return data[6];
        }

        public string GetTimezone()
        {
            return data[7];
        }

        public string GetUtcOffset()
        {
            return data[8];
        }

        public string GetChinaAdminCode()
        {
            return data[9];
        }

        public string GetIddCode()
        {
            return data[10];
        }

        public string GetCountryCode()
        {
            return data[11];
        }

        public string GetContinentCode()
        {
            return data[12];
        }

        public string GetIDC()
        {
            return data[13];
        }

        public string GetBaseStation()
        {
            return data[14];
        }

        public string GetCountryCode3()
        {
            return data[15];
        }

        public string GetEuropeanUnion()
        {
            return data[16];
        }

        public string GetCurrencyCode()
        {
            return data[17];
        }

        public string GetCurrencyName()
        {
            return data[18];
        }

        public string GetAnycast()
        {
            return data[19];
        }

        public override string ToString()
        {

            var sb = new StringBuilder();

            sb.Append("country_name:");
            sb.Append(GetCountryName());
            sb.Append("\n");
            sb.Append("region_name:");
            sb.Append(GetRegionName());
            sb.Append("\n");
            sb.Append("city_name:");
            sb.Append(GetCityName());
            sb.Append("\n");
            sb.Append("owner_domain:");
            sb.Append(GetOwnerDomain());
            sb.Append("\n");
            sb.Append("isp_domain:");
            sb.Append(GetIspDomain());
            sb.Append("\n");
            sb.Append("latitude:");
            sb.Append(GetLatitude());
            sb.Append("\n");
            sb.Append("longitude:");
            sb.Append(GetLongitude());
            sb.Append("\n");

            sb.Append("timezone:");
            sb.Append(GetTimezone());
            sb.Append("\n");

            sb.Append("utc_offset:");
            sb.Append(GetUtcOffset());
            sb.Append("\n");

            sb.Append("china_admin_code:");
            sb.Append(GetChinaAdminCode());
            sb.Append("\n");

            sb.Append("idd_code:");
            sb.Append(GetIddCode());
            sb.Append("\n");

            sb.Append("country_code:");
            sb.Append(GetCountryCode());
            sb.Append("\n");

            sb.Append("continent_code:");
            sb.Append(GetContinentCode());
            sb.Append("\n");

            sb.Append("idc:");
            sb.Append(GetIDC());
            sb.Append("\n");

            sb.Append("base_station:");
            sb.Append(GetBaseStation());
            sb.Append("\n");

            sb.Append("country_code3:");
            sb.Append(GetCountryCode3());
            sb.Append("\n");

            sb.Append("european_union:");
            sb.Append(GetEuropeanUnion());
            sb.Append("\n");

            sb.Append("currency_code:");
            sb.Append(GetCurrencyCode());
            sb.Append("\n");

            sb.Append("currency_name:");
            sb.Append(GetCurrencyName());
            sb.Append("\n");

            sb.Append("anycast:");
            sb.Append(GetAnycast());

            return sb.ToString();

        }
    }

}
