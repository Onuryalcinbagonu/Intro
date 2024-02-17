using Intro.DataAccess.Abstracts;
using Intro.DataAccess.Concretes;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    //dependency injection işlemidir.
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }




    // Metotlar
    public List<Course> GetAll() 
    {//GetAll() metodu çağırılırsa Course[] Array i döndürülür
        
        // Business rules // iş kuralı şu kadar puan aldıysa şu mezunsa gibi.
        //CourseDal courseDal= new CourseDal();
        // Newlemek yanlış.
        return _courseDal.GetAll();
       
    }

    // Her bir klasör bir katmana karşılık gelir.
    // Hiç bir katman birbirini new leyemez. Yani Business DataAccess'i newleyemez.
    // Sadece soyutlarından erişebilir ICourseDal gibi
    // Entites 3 asıl katmandan biri değildir.
}
