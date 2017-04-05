using LTEExcelAddIn.WPF.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.ComponentModel;

namespace LTEExcelAddIn.WPF.ViewModels
{
    class MainViewModel
    {
        private const string query = @"
SELECT
    wiloCharacteristics.idWiloArt AS 'Artikul',
    wiloCharacteristics.oldIdWiloArt AS 'OldArtikul',
    wiloCharacteristics.type AS 'Name',
    wiloCharacteristics.height AS 'Height',
    wiloCharacteristics.diametr AS 'Diametr',
    wiloCharacteristics.capacitor AS 'Capacitor', 
    wiloCharacteristics.idRotor AS 'ArtikulRotor',
    wiloRotors.type AS 'NameRotor',
    wiloWheels.idWheel AS 'ArtikulWheel',
    CASE
        WHEN wiloWheels.type IS NULL THEN wiloRotors.typeWheel
        ELSE wiloWheels.type
    END AS 'NameWheel',
    COUNT(motors_lte.idWiloArt) AS 'Quantity'
FROM 
    wiloCharacteristics LEFT OUTER JOIN wiloRotors USING(idRotor) 
        LEFT OUTER JOIN wiloWheels USING(idWheel)
            LEFT OUTER JOIN motors_lte USING(idwiloArt)
GROUP BY
    wiloCharacteristics.idWiloArt
ORDER BY
    Quantity DESC,
    wiloCharacteristics.type;  
    ";
        private string filterPump;
        private bool isFilterByPumpName;
        private bool isFilterByPumpArtikul;
        private bool isFilterByPumpOldArtikul;
        private bool isFilterByRotorArtikul;
        private bool isFilterByWheelArtikul;

        public ICollectionView PumpsListView;

        public ObservableCollection<Pump> PumpsList { get; set; }

        public string FilterPump
        {
            get { return filterPump; }
            
            set
            {
                if (value != filterPump)
                {
                    filterPump = value;
                    PumpsListView.Refresh();
                }
            }
        }

        public bool IsFilterByPumpName
        {
            get { return isFilterByPumpName; }

            set
            {
                if (value != isFilterByPumpName)
                {
                    isFilterByPumpName = value;
                    if (isFilterByPumpName)
                    {
                        PumpsListView.Filter = FilterByPumpName;
                    }
                }
            }
        }

        public bool IsFilterByPumpArtikul
        {
            get { return isFilterByPumpArtikul; }

            set
            {
                if (value != isFilterByPumpArtikul)
                {
                    isFilterByPumpArtikul = value;
                    if (isFilterByPumpArtikul)
                    {
                        PumpsListView.Filter = FilterByPumpArtikul;
                    }
                }
            }
        }

        public bool IsFilterByPumpOldArtikul
        {
            get { return isFilterByPumpOldArtikul; }
            set
            {
                if (value != isFilterByPumpOldArtikul)
                {
                    isFilterByPumpOldArtikul = value;
                    PumpsListView.Filter = FilterByPumpArtikul;
                }
            }
        }

        public bool IsFilterByRotorArtikul
        {
            get { return isFilterByRotorArtikul; }

            set
            {
                if (value != isFilterByRotorArtikul)
                {
                    isFilterByRotorArtikul = value;
                    if (isFilterByRotorArtikul)
                    {
                        PumpsListView.Filter = FilterByRotorArtikul;
                    }
                }
            }
        }

        public bool IsFilterByWheelArtikul
        {
            get { return isFilterByWheelArtikul; }

            set
            {
                if (value != isFilterByWheelArtikul)
                {
                    isFilterByWheelArtikul = value;
                    if (isFilterByWheelArtikul)
                    {
                        PumpsListView.Filter = FilterByWheelArtikul;
                    }
                }
            }
        }

        public MainViewModel()
        {
            using (MySqlConnection connect = new MySqlConnection(Ribbon.connectString.ConnectionString))
            {
                connect.Open();
                MySqlCommand command = new MySqlCommand(query, connect);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    PumpsList = new ObservableCollection<Pump>();
                    InitializePumpsList(reader);
                    PumpsListView = CollectionViewSource.GetDefaultView(PumpsList);
                    IsFilterByPumpOldArtikul = true;
                    IsFilterByPumpName = true;
                }
                command.Dispose();
             }
        }

        private void InitializePumpsList(MySqlDataReader reader)
        {
            while (reader.Read())
            {
                Pump pump = new Pump();
                pump.Artikul = reader.GetInt32("Artikul");
                if (!reader.IsDBNull(1))
                {
                    pump.OldArtikul = reader.GetInt32("OldArtikul");
                }
                pump.Name = reader.GetString("Name");
                if (!reader.IsDBNull(3))
                {
                    pump.Height = reader.GetInt32("Height");
                }
                if (!reader.IsDBNull(4))
                {
                    pump.Diametr = reader.GetString("Diametr");
                }
                if (!reader.IsDBNull(5))
                {
                    pump.Capacitor = reader.GetInt32("Capacitor");
                }
                if (!reader.IsDBNull(6))
                {
                    pump.ArtikulRotor = reader.GetInt32("ArtikulRotor");
                }
                if (!reader.IsDBNull(6))
                {
                    pump.ArtikulRotor = reader.GetInt32("ArtikulRotor");
                }
                if (!reader.IsDBNull(7))
                {
                    pump.NameRotor = reader.GetString("NameRotor");
                }
                if (!reader.IsDBNull(8))
                {
                    pump.ArtikulWheel = reader.GetInt32("ArtikulWheel");
                }
                if (!reader.IsDBNull(9))
                {
                    pump.NameWheel = reader.GetString("NameWheel");
                }
                pump.Quantity = reader.GetInt32("Quantity");
                PumpsList.Add(pump);
            }
        }

        private bool FilterByPumpName(object item)
        {
            Pump pump = item as Pump;
            if (String.IsNullOrEmpty(FilterPump) || pump == null)
            {
                return true;
            }
            else
            {
                return pump.Name.StartsWith(FilterPump, true, null);
            }
        }

        private bool FilterByPumpArtikul(object item)
        {
            Pump pump = item as Pump;
            if (String.IsNullOrEmpty(FilterPump) || pump == null)
            {
                return true;
            }
            else
            {
                if (IsFilterByPumpOldArtikul)
                {
                    return (pump.Artikul.ToString().StartsWith(FilterPump, true, null) || pump.OldArtikul.ToString().StartsWith(FilterPump, true, null));
                }
                else
                {
                    return pump.Artikul.ToString().StartsWith(FilterPump, true, null); 
                }
            }
        }

        private bool FilterByRotorArtikul(object item)
        {
            Pump pump = item as Pump;
            if (String.IsNullOrEmpty(FilterPump) || pump == null)
            {
                return true;
            }
            else
            {
                return pump.ArtikulRotor.ToString().StartsWith(FilterPump, true, null);
            }
        }

        private bool FilterByWheelArtikul(object item)
        {
            Pump pump = item as Pump;
            if (String.IsNullOrEmpty(FilterPump) || pump == null)
            {
                return true;
            }
            else
            {
                return pump.ArtikulWheel.ToString().StartsWith(FilterPump, true, null);
            }
        }
    }
}