using Autodesk.AutoCAD.Runtime;

using Autodesk.AutoCAD.ApplicationServices;

using Autodesk.AutoCAD.DatabaseServices;

using Autodesk.AutoCAD.Geometry;

using Autodesk.AutoCAD.EditorInput;

namespace WPF
{
    /// <summary>
    /// Выбор примитивов
    /// </summary>
   public class SelectClass
    {
        [CommandMethod("SelectObjectsByCrossingWindow")]

        public static void SelectObjectsByCrossingWindow()

        {
            
            // Get the current document editor /Получить текущий редактор документов

            Editor acDocEd = Application.DocumentManager.MdiActiveDocument.Editor;



            // Create a crossing window from (2,2,0) to (10,8,0)/Создание секущей рамки от (2,2,0) до (10,8,0)

            PromptSelectionResult acSSPrompt;

            acSSPrompt = acDocEd.SelectCrossingWindow(new Point3d(2, 2, 0),

                                                      new Point3d(10, 8, 0));



            // If the prompt status is OK, objects were selected /Если состояние приглашения ОК, то объекты были выбраны

            if (acSSPrompt.Status == PromptStatus.OK)

            {

                SelectionSet acSSet = acSSPrompt.Value;



                Application.ShowAlertDialog("Number of objects selected: " +

                                            acSSet.Count.ToString());

            }

            else

            {

                Application.ShowAlertDialog("Number of objects selected: 0");

            }

        }
    }
}





 

