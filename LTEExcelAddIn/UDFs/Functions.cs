using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ExcelDna.Integration;

namespace UDFs
{
    public static class Functions
    {

        //ДОБАВИТИ ФУНКЦІЇ (струм, напруга)
        //КОМЕНТАРІ ДО ФУНКЦІЙ

        [ExcelFunction(Name = "ЕЛЕКТРОЕНЕРГІЯ_ДВОХЗОННИЙ_09_16", Description = "Дана формула, розраховує суму за спожиту електроенергію за двозонним лічильником, по тарифах на електроенергію для населення з 01.09.2016 по 28.02.2017")]
        public static decimal ElectricPowerDoubleZones_09_16([ExcelArgument(Name = "День", Description = "Кількість спожитих кВт*год в денний період (денна зона — 7.00-23.00)")] int day,
                                  [ExcelArgument(Name = "Ніч", Description = "Кількість спожитих кВт*год в нічний період (нічна зона  — 23.00-7.00)")] int night)
        {
            const int limit1 = 100;
            const int limit2 = 600;
            const decimal tarriff1 = 0.714m;
            const decimal tarriff2 = 1.29m;
            const decimal tarriff3 = 1.638m;
            const double nightCoefficient = 0.5;

            decimal result = 0;
            int sum = day + night;
            
            if (day < 0 || night < 0 || sum <= 0)
            {
                return result;
            }
            else
            {
                double dayPercent = (double) day / sum;
                double nightPercent = (double) night / sum;

                if (sum <= limit1)
                {
                    result = (decimal) ( (day * (double) tarriff1) + (night * (double) tarriff1 * nightCoefficient) );
                }
                else if (sum <= limit2)
                {
                    result = (decimal) ( (Math.Round(limit1 * dayPercent) * (double) tarriff1)  + (Math.Round(limit1 * nightPercent) * (double) tarriff1 * nightCoefficient) ) ;
                    result += (decimal) ( (Math.Round((sum - limit1) * dayPercent) * (double) tarriff2) + (Math.Round((sum - limit1) * nightPercent) * (double) tarriff2 * nightCoefficient) );
                }
                else
                {
                    result = (decimal) ( (Math.Round(limit1 * dayPercent) * (double) tarriff1) + (Math.Round(limit1 * nightPercent) * (double) tarriff1 * nightCoefficient) );
                    result += (decimal) ( (Math.Round((limit2 - limit1) * dayPercent) * (double) tarriff2) + (Math.Round((limit2 - limit1) * nightPercent) * (double) tarriff2 * nightCoefficient) );
                    result += (decimal) ( (Math.Round((sum - limit2) * dayPercent) * (double) tarriff3) + (Math.Round((sum - limit2) * nightPercent) * (double) tarriff3 * nightCoefficient) );
                }
                return result;
            }
        }

        [ExcelFunction(Name = "ЕЛЕКТРОЕНЕРГІЯ_ДВОХЗОННИЙ_03_17", Description = "Дана формула, розраховує суму за спожиту електроенергію за двозонним лічильником, по тарифах на електроенергію для населення з 01.03.2017")]
        public static decimal ElectricPowerDoubleZones_03_17([ExcelArgument(Name = "День", Description = "Кількість спожитих кВт*год в денний період (денна зона — 7.00-23.00)")] int day,
                                  [ExcelArgument(Name = "Ніч", Description = "Кількість спожитих кВт*год в нічний період (нічна зона  — 23.00-7.00)")] int night)
        {
            const int limit = 100;
            const decimal tarriff1 = 0.9m;
            const decimal tarriff2 = 1.68m;
            const double nightCoefficient = 0.5;

            decimal result = 0;
            int sum = day + night;

            if (day < 0 || night < 0 || sum <= 0)
            {
                return result;
            }
            else
            {
                double dayPercent = (double)day / sum;
                double nightPercent = (double)night / sum;

                if (sum <= limit)
                {
                    result = (decimal)((day * (double)tarriff1) + (night * (double)tarriff1 * nightCoefficient));
                }
                else
                {
                    result = (decimal)((Math.Round(limit * dayPercent) * (double)tarriff1) + (Math.Round(limit * nightPercent) * (double)tarriff1 * nightCoefficient));
                    result += (decimal)((Math.Round((sum - limit) * dayPercent) * (double)tarriff2) + (Math.Round((sum - limit) * nightPercent) * (double)tarriff2 * nightCoefficient));
                }
                return result;
            }
        }

        [ExcelFunction(Name = "ГАЗ_05_16", Description = "Дана формула, розраховує суму за спожитий газ, по тарифах на природний газ для населення з 01.05.2016")]
        public static decimal Gas_05_16([ExcelArgument(Name = "Об'єм", Description = "Кількість спожитих м.куб.")] int value)
        {
            const decimal tarriff = 6.879m;
            if(value <= 0)
            {
                return 0;
            }
            else
            {
                return value * tarriff;           
            }
        }
    }
}