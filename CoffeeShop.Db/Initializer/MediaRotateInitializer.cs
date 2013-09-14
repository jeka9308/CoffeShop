using System.Collections.Generic;
using System.Data.Entity;
using MediaRotate.Db.Context;
using MediaRotate.Domain.Models;

namespace MediaRotate.Db.Initializer
{
    public class MediaRotateInitializer : DropCreateDatabaseAlways<MediaRotateContext>
    {
        protected override void Seed(MediaRotateContext context)
        {
            var sizes = new List<Size>
                {
                    new Size(){Width = 480, Height = 60},
                    new Size(){Width = 125, Height = 125},
                    new Size(){Width = 728, Height = 90},
                    new Size(){Width = 120, Height = 60},
                    new Size(){Width = 300, Height = 250},
                    new Size(){Width = 250, Height = 250},
                };

            sizes.ForEach(s => context.Sizes.Add(s));

            context.SaveChanges();
        }
    }
}