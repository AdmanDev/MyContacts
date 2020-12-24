using System;
using System.Collections.Generic;

namespace MyContacts
{
    // Cette classe est accessible depuis n'importe où sans à avoir l'instancier
    public static class Global
    {
        //__________________________________VARIABLES__________________________________//
       
        //Instance de la fenêtre principale
        public static MainWindow mainWindow;

        //Liste des groupes de contacts de l'utilisateur
        public static List<Group> contactsGroup;

        //Ajouter un groupe
        public static void AddGroup(Group groupToAdd)
        {
            contactsGroup.Add(groupToAdd);
            SaveManager.Save(contactsGroup);

            mainWindow.LoadGroup();
        }

        //Supprimer un groupe
        public static void DeleteGroup(Group group)
        {
            contactsGroup.Remove(group);
            SaveManager.Save(contactsGroup);

            mainWindow.LoadGroup();
        }
    }
}
