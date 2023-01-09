using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Gateway
{
  public class RegisterGateway
  {
    ApplicationDbContext _dbContext = new ApplicationDbContext();


    public bool Add(Student student)
    {
      _dbContext.Database.EnsureCreated();
      _dbContext.Students.Add(student);
      return _dbContext.SaveChanges() > 0;
    }

    internal List<Student> GetAll()
    {
      _dbContext.Database.EnsureCreated();
      return _dbContext.Students.ToList();
    }

    internal List<Student> GetData(string ReAdd)
    {
      _dbContext.Database.EnsureCreated();
      return  _dbContext.Students
              .Where(s => s.registerAddress == ReAdd)
              .OrderByDescending(s=>s.Id)
              .Take(2)
              .ToList();
    }
  }
}
