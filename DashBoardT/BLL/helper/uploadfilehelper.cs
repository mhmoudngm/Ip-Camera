using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoardT.BLL.helper
{
    public static class uploadfilehelper
    {
        public static String savefile(IFormFile fileurl,String folderpath)
        {
            String filepath = Directory.GetCurrentDirectory() + "/wwwroot/files/" + folderpath;
            String filename = Guid.NewGuid() + Path.GetFileName(fileurl.FileName);
            String finalpath = Path.Combine(filepath, filename);
            using (var stream = new FileStream(finalpath, FileMode.Create))
            {
                fileurl.CopyTo(stream);
            }
            return filename;

        }

        public static void remove(String foldername,String removedfilename)
        {
            if(File.Exists(Directory.GetCurrentDirectory()+"/wwwroot/files/"+foldername+removedfilename))
            {
                File.Delete(Directory.GetCurrentDirectory() + "/wwwroot/files/" + foldername + removedfilename);
            }
        }
    }
}
