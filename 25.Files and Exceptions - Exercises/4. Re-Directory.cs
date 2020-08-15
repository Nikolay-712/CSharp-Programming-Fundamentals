using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class Test
 {
     static void Main()
     {
        var infoFiles = new Dictionary<string, List<string>>();
        List<string> input = Directory.GetFiles(@"D:\Re-Directory\input").ToList();

        foreach (var item in input)
        {
            FileInfo info = new FileInfo(item);
            var extension = info.Extension;

            if (!infoFiles.ContainsKey(extension))
            {
                infoFiles[extension] = new List<string>();
            }
            infoFiles[extension].Add(info.Name);
            
        }

        foreach (var item in infoFiles)
        {
            string folderName = @"D:\Input";
            string pathString = Path.Combine(folderName, item.Key);

            Directory.CreateDirectory(pathString);

            foreach (var file in item.Value)
            {
                var source = Path.Combine(@"D:\Re-Directory\input", file);
                var destination = Path.Combine(pathString, file);

                File.Copy(source, destination);

            }
        }


        
    }
 }
