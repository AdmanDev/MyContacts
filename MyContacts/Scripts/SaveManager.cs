using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;

namespace MyContacts
{
    public static class SaveManager
    {
        //Variables
        private const string filePath = "Data.bin";

        //Sauvegarder les données
        public static void Save(List<Group> data)
        {
            //Création (et ouverture) d'un nouveau fichier
            FileStream fs = File.Create(filePath);
            //Enregistrement des données dans le fichier
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, data);

            //Fermeture du fichier
            fs.Close();
        }

        //Ouvre les données
        public static List<Group> Open()
        {
            //Création d'une liste de groupes par défaut
            //Si le fichier n'éxiste pas, la liste par défaut sera utilisé
            List<Group> data = new List<Group>()
            {
                new Group("Amis"),
                new Group("Travail"),
                new Group("Famille")
            };

            //Si le fichier existe...
            if (File.Exists(filePath))
            {
                FileStream fs = null;

                try
                {
                    //Lecture du fichier
                    fs = File.OpenRead(filePath);
                    //Création de la liste de groupes (et de contacts) à partir du fichier ouvert
                    BinaryFormatter bf = new BinaryFormatter();
                    data = (List<Group>)bf.Deserialize(fs);
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    //Si un fichier a été ouvert..
                    if(fs != null)
                    {
                        //On le ferme
                        fs.Close();
                    }
                }
            }

            return data;
        }
    }
}
