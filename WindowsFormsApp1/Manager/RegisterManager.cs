using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Gateway;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Manager
{
  public class RegisterManager
  {
    RegisterGateway _registerGateway = new RegisterGateway();

    public bool Add(Student student)
    {
      return _registerGateway.Add(student);
    }

    public List<Student> GetAll()
    {
      return _registerGateway.GetAll();
    }

    public List<Student> GetData(string ReAdd)
    {
      return _registerGateway.GetData(ReAdd);
    }
  }
}
