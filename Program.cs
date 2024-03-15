using System;
using OfficeOpenXml;
using System.IO;
using System.Collections;
using System.Threading.Tasks;

namespace LostTreasure_MonsterMaker
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var file = new FileInfo("monsters.xlsx");

            var monster = GetMonsterModels();

            await SaveExcelFile(monster, file);
        }

        private static async Task SaveExcelFile(List<MonsterModel> monster, FileInfo file)
        {
            DeleteFileIfExists(file);

            using (var package = new ExcelPackage(file))
            {
                var work_sheet = package.Workbook.Worksheets.Add("Monster(s)");

                var range = work_sheet.Cells["A1"].LoadFromCollection(monster, true);
                range.AutoFitColumns();

                await package.SaveAsync();
            }
        }

        private static void DeleteFileIfExists(FileInfo file)
        {
            if(file.Exists)
            {
                file.Delete();
            }
        }

        private static List<MonsterModel> GetMonsterModels()
        {
            List<MonsterModel> output = new()
            {
                new() {Name = "bandid", Description = "desc", Level = 1, Blood = 10, Aura = 0, DefenseDie = "1d6", SpellDefenseDie = "1d4", Strength = 1, Dexterity = 2, Constitution = 3, Intelligence = 4, Social = 5, SkillMastery = "jump, stealth, steal", Weapons = "dagger, dagger"}
            };

            return output;
        }
    }
}