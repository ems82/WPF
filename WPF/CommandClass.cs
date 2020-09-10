
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform = System.Windows.Forms;

namespace WPF
{
    /// <summary>
    /// Коммандный класс выввода слоев
    /// </summary>
    public class CommandClass
    {
        [CommandMethod("CLD")]
        public void RunCommand()
        {
            // Получаем ссылку на активный документ
            Document adoc = Application.DocumentManager.MdiActiveDocument;
            // Если документ не получен выход
            if (adoc == null)
                return;
            // Получаем базу данных открытого документа
            Database db = adoc.Database;
            //Получаем редактор документа
            Editor ed = adoc.Editor; // может и не нужен

            Form_CreateLayer form = new Form_CreateLayer(); // Создаем форму
            Winform.DialogResult diaRes = Application.ShowModalDialog(form); // запускаем форму и получаем  результат диалога
            if (diaRes != Winform.DialogResult.OK) return;
            // Получаем из объекта формы заданные пользователем значения
            string layerName = form.LayerName;
            bool layerIsOn = form.LayerIsOn;
            bool layerIsFrozen = form.LayerIsFrozen;
            //Запускаем транзакцию
            using (Transaction tr = db.TransactionManager.StartTransaction()) // транзакции позволяют безопасно работать с объектами ACad
            {
                // Получаем объект таблицы слоев
                LayerTable lt = (LayerTable)tr.GetObject(db.LayerTableId, OpenMode.ForRead);
                try
                {
                    // Проверяем название слоя на недопустимые ситволы 
                    // этот метод выдает исключения поэтому заключен в блок try catch
                    SymbolUtilityServices.ValidateSymbolName(layerName, false);
                }
                catch
                {
                    // Если возникло исключение то удалякм название слоя
                    Application.ShowAlertDialog("Недопустимое название слоя");
                    layerName = null;
                }

                if (!string.IsNullOrEmpty(layerName))
                {   
                    // Если название не удалено и отсутствует в списке слоев
                    if (!lt.Has(layerName))
                    {
                        // Соооздаем новую запись о  слое
                        LayerTableRecord ltr = new LayerTableRecord();
                        //Задаем ему свойства
                        ltr.Name = layerName;
                        ltr.IsOff = !layerIsOn;
                        ltr.IsFrozen = layerIsFrozen;

                        //Добавляем слой в таблицу слоев и в транзакцию
                        lt.UpgradeOpen();
                        lt.Add(ltr);
                        tr.AddNewlyCreatedDBObject(ltr, true);
                    }
                    else
                    {
                        Application.ShowAlertDialog("Такой слой уже есть!");

                    }
                }

                tr.Commit();  // подтверждение транзакции

            }
        }
    }
}
