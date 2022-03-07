using MySql.Data.MySqlClient;
using SWADELib;
using System.Windows.Forms;

namespace SwadeXmlTool
{
    internal class DbController
    {
        private MySqlConnection dbConnection;

        public DbController()
        {
            dbConnection = null;
        }

        private void ConnectToMainDb()
        {
            dbConnection = NOSDBLib.SwadeDb.SwadeDbConnector.Connect();
        }

        public List<SWADEAttribute> GetAllAttributes()
        {
            List<SWADEAttribute> attributes = new List<SWADEAttribute>();
            ConnectToMainDb();

            string cmdText = $"SELECT * FROM SWADE.attribute;";
            MySqlCommand cmd = new MySqlCommand(cmdText, dbConnection);
            dbConnection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Guid attributeId = Guid.Parse(reader.GetString(0));
                SWADEAttribute newAttribute = new SWADEAttribute(
                    attributeId,
                    reader.GetString(2),
                    reader.GetString(3));

                attributes.Add(newAttribute);
            }

            dbConnection.Close();
            return attributes;
        }
        public List<SWADESkill> GetAllSkills(List<SWADEAttribute> attributes)
        {
            List<SWADESkill> skills = new List<SWADESkill>();
            ConnectToMainDb();

            string cmdText = $"SELECT * FROM SWADE.skill;";
            MySqlCommand cmd = new MySqlCommand(cmdText, dbConnection);
            dbConnection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Guid skillId = Guid.Parse(reader.GetString(0));
                Guid attributeId = Guid.Parse(reader.GetString(3));

                SWADEAttribute skillAttribute = null;
                foreach(SWADEAttribute attribute in attributes)
                {
                    if(attribute.ID == attributeId)
                    {
                        skillAttribute = attribute;
                        break;
                    }
                }

                if(skillAttribute == null)
                {
                    return null;
                }

                SWADESkill newSkill = new SWADESkill(
                    skillId,
                    reader.GetString(2),
                    reader.GetString(5),
                    skillAttribute,
                    reader.GetBoolean(4));

                skills.Add(newSkill);
            }

            dbConnection.Close();
            return skills;
        }
        public void WriteNewAttribute(string attributeId, SWADEAttribute attribute, string attributeLang = "EN")
        {
            string cmdText = $"INSERT INTO SWADE.attribute VALUES (" +
                $"'{attributeId}'," +
                $"'{attributeLang}'," +
                $"'{attribute.Name}'," +
                $"'{attribute.Description}');";

            MySqlCommand cmd = new MySqlCommand(cmdText, dbConnection);

            try
            {
                dbConnection.Open();
                int linesAffected = cmd.ExecuteNonQuery();

                if(linesAffected == 0)
                {
                    MessageBox.Show("Values did not add successfully");
                }
                else
                {
                    MessageBox.Show($"Successfully Added {attribute.Name} to DB");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnection?.Close();
            }
        }
    }
}
