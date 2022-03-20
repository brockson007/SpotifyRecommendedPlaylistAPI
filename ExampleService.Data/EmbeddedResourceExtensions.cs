using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace ExampleService.Data
{
    public static class EmbeddedResourceExtensions
    {
        // Return a list of statements that are separated based on any GO statements in the SQL script.
        public static List<string> GetSQLResourceFileText(this object obj, string resourceName)
        {
            try
            {
                Assembly assem = obj.GetType().Assembly;
                Stream ms = assem.GetManifestResourceStream(resourceName);

                if (ms == null)
                {
                    throw new Exception("The embedded resource (" + resourceName + ") was not found.");
                }

                List<string> returnValue = new List<string>();
                StreamReader sr = new StreamReader(ms);
                StringBuilder sb = new StringBuilder(sr.ReadToEnd());

                string holdString = sb.ToString();
                string[] lines = holdString.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

                sb.Clear();

                for (int index = 0; index <= lines.GetUpperBound(0); index++)
                {
                    if (lines[index].Trim().ToUpper() == "GO")
                    {
                        holdString = sb.ToString();
                        if (!String.IsNullOrWhiteSpace(holdString))
                        {
                            returnValue.Add(holdString);
                        }
                        sb.Clear();
                    }
                    else
                    {
                        sb.AppendLine(lines[index]);
                    }
                }

                holdString = sb.ToString();
                if (!String.IsNullOrWhiteSpace(holdString))
                {
                    returnValue.Add(holdString);
                }

                return returnValue;
            }
            catch (Exception ex)
            {
                List<string> nullList = new List<string>();
                nullList.Add("");
                MethodBase methodBase = MethodBase.GetCurrentMethod();
                EventLog.WriteEntry(methodBase.Name, ex.Message, EventLogEntryType.Information);
                return nullList;
            }
        }
    }
}
