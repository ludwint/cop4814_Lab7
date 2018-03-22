using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Lab2Game
{
    
    public class GameFactory
    {
        StreamWriter sw;
        XmlSerializer serial;
        List<Game> gameList;
        const string FILE_PATH = @"..\..\games.xml";
        public void CreateGameList()
        {
            gameList = new List<Game>();
            Game G = new Game("Barcelona", "Real Madrid", 3, 0);
            gameList.Add(G);
            G = new Game("Peru", "Iceland", 3, 0);
            gameList.Add(G);
            G = new Game("Barcelona", "Chelsea", 2, 0);
            gameList.Add(G);
            G = new Game("Peru", "Croatia", 2, 0);
            gameList.Add(G);
            G = new Game("Peru", "France", 4, 2);
            gameList.Add(G);
            G = new Game("Peru", "Denmark", 3, 0);
            gameList.Add(G);
            G = new Game("Peru", "Australia", 4, 1);
            gameList.Add(G);

            serial = new XmlSerializer(gameList.GetType());
            sw = new StreamWriter(FILE_PATH);
            serial.Serialize(sw, gameList);
            sw.Close();
        }

        public List<Game> DeserializeGameList(out string resultMessage)
        {
            try
            {
                gameList = new List<Game>();
                StreamReader sr = new StreamReader(FILE_PATH);
                serial = new XmlSerializer(gameList.GetType());
                gameList = (List<Game>)serial.Deserialize(sr);
                sr.Close();
                resultMessage = "success";
                return gameList;
            }
            catch (Exception ex)
            {
                resultMessage = "Exception thrown: " + ex.Message;
                return null;
            }
            

        }
    }
}
