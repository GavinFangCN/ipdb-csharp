using System.Text;

namespace ipdb
{

    public class BaseStationInfo
    {

        private readonly string[] data;

        public BaseStationInfo(string[] data)
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

        public string GetBaseStation()
        {
            return data[5];
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
            sb.Append("base_station:");
            sb.Append(GetBaseStation());

            return sb.ToString();
        }
    }

}
