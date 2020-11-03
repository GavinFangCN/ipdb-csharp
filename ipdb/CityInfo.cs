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

        public string GetCountryName() => GetValueSafe(0);

        public string GetRegionName() => GetValueSafe(1);

        public string GetCityName() => GetValueSafe(2);

        public string OwnerDomain => GetValueSafe(3);

        public string IspDomain => GetValueSafe(4);

        public string GetLatitude() => GetValueSafe(5);

        public string GetLongitude() => GetValueSafe(6);

        public string GetTimezone() => GetValueSafe(7);

        public string GetUtcOffset() => GetValueSafe(8);

        public string GetChinaAdminCode() => GetValueSafe(9);

        public string GetIddCode() => GetValueSafe(10);

        public string GetCountryCode() => GetValueSafe(11);

        public string GetContinentCode() => GetValueSafe(12);

        public string GetIDC() => GetValueSafe(13);

        public string GetBaseStation() => GetValueSafe(14);

        public string GetCountryCode3() => GetValueSafe(15);

        public string GetEuropeanUnion() => GetValueSafe(16);

        public string GetCurrencyCode() => GetValueSafe(17);

        public string GetCurrencyName() => GetValueSafe(18);

        public string GetAnycast() => GetValueSafe(19);

        private string GetValueSafe(int index)
            => data?.Length > index ? data[index] : string.Empty;

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
            sb.Append(OwnerDomain);
            sb.Append("\n");
            sb.Append("isp_domain:");
            sb.Append(IspDomain);
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
