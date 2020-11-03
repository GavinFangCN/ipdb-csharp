using System.Text;

namespace ipdb
{

    public class DistrictInfo
    {

        private readonly string[] data;

        public DistrictInfo(string[] data)
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

        public string GetDistrictName()
        {
            return data[3];
        }

        public string GetChinaAdminCode()
        {
            return data[4];
        }

        public string GetCoveringRadius()
        {
            return data[5];
        }

        public string GetLatitude()
        {
            return data[7];
        }

        public string GetLongitude()
        {
            return data[6];
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
            sb.Append("district_name:");
            sb.Append(GetDistrictName());
            sb.Append("\n");
            sb.Append("china_admin_code:");
            sb.Append(GetChinaAdminCode());
            sb.Append("\n");
            sb.Append("covering_radius:");
            sb.Append(GetCoveringRadius());
            sb.Append("\n");
            sb.Append("latitude:");
            sb.Append(GetLatitude());
            sb.Append("\n");
            sb.Append("longitude:");
            sb.Append(GetLongitude());

            return sb.ToString();
        }
    }

}
