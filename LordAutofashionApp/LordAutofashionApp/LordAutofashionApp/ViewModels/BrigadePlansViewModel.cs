using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;

namespace LordAutofashionApp.ViewModels
{
    public class BrigadePlansViewModel
    {
        private ObservableCollection<BrigadePlan> items;
        public ObservableCollection<BrigadePlan> Items {
            get { return items; }
            set {

                items = value;
            }
        }


        public BrigadePlansViewModel() {

            // Here you can have your data form db or something else,
            // some data that you already have to put in the list
            Items = new ObservableCollection<BrigadePlan>() {
                new BrigadePlan()
                {
                    BrigadeNumber = "02.1 Швейная бригада 1 (Андреева №1)",
                    Number = "000047107",
                    Date = "29.11.2022",
                    SeatsModel = "Opel Astra -3 H, 08.2004-10.2011, L35, Универс. 5дв., Разд.зад.спин.и сид. 60/40, 2Прям.подгол.",
                    NumberOfTacts = "45350",
                    InProcess = true,
                    IsDone = false
                },
                new BrigadePlan()
                {
                    BrigadeNumber = "03.1 Швейная бригада 2 (Будилова №1)",
                    Number = "000047112",
                    Date = "28.11.2022",
                    SeatsModel = "Kia Cerato -2, 10.2008-03.2013, TD, Седан. Разд.зад.спин. 40/60, надкрыл-ки, 2Г-образн.подголовн.",
                    NumberOfTacts = "43804",
                    InProcess = true,
                    IsDone = true
                },

            };
        }
    }

    public class BrigadePlan
    {
        public string BrigadeNumber { get; set; }

        public string Number { get; set; }

        public string Date { get; set; }

        public string SeatsModel { get; set; }

        public string NumberOfTacts { get; set; }

        public bool InProcess { get; set; }

        public bool IsDone { get; set; }
    }
}