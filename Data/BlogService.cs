using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace CS401_Final_Blazor.Data
{
    public class BlogService
    {
        public const string BlogFileName = "Blogs.json";
        public BlogModel GetBlog(Guid id)
        {
            BlogModel model = GetBlogsFromFile().Where(x => x.Id == id).FirstOrDefault();
            return model;
        }
        public List<BlogModel> GetBlogsFromFile()
        {
            using (FileStream file = File.Open(BlogFileName, FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string ret = sr.ReadToEnd();
                    if (!string.IsNullOrWhiteSpace(ret))
                        return JsonSerializer.Deserialize<List<BlogModel>>(ret).OrderByDescending(x => x.LastModified).ToList();
                    else
                        return new List<BlogModel>();
                }
            }
        }

        public bool SaveNewBlogToFile(BlogModel newBlog)
        {
            List<BlogModel> list = GetBlogsFromFile();
            list.Add(newBlog);
            WriteToFile(list);
            return true;
        }
        public bool EditExistingBlog(BlogModel existingBlog)
        {
            List<BlogModel> list = GetBlogsFromFile();
            var newList = list.Select(x => { if (x.Id == existingBlog.Id) x = existingBlog; return x; }).ToList();
            WriteToFile(newList);
            return true;
        }

        public bool DeleteExistingBlog(Guid id)
        {
            List<BlogModel> list = GetBlogsFromFile();
            if(list.RemoveAll(x => x.Id == id) > 0)
                WriteToFile(list);
            return true;
        }

        public bool CreateNewBlog(BlogModel model)
        {
            List<BlogModel> list = GetBlogsFromFile();
            list.Add(model);
            WriteToFile(list);
            return true;
        }

        private void WriteToFile(List<BlogModel> list)
        {
            using (StreamWriter file = new(BlogFileName))
            {
                file.Write(JsonSerializer.Serialize(list));
            }
        }
    }
}
