using API_GrupoFleury.models;
using System;
using API_GrupoFleury.Context;
using System.Collections.Generic;
using System.Linq;


namespace API_GrupoFleury.service
{
  public class ExamService
  {
    private readonly AppDbContext _context;

    public ExamService(AppDbContext context)
    {
      _context = context;
    }
    public IEnumerable<Exam> GetAll()
    {
      return _context.Exam.ToList();
    }
    public void Add(Exam exam)
    {
      _context.Exam.Add(exam);
      _context.SaveChanges();
    }
    public void Update(Exam exam)
    {
      _context.Exam.Update(exam);
      _context.SaveChanges();
    }
    public void Delete(Guid id)
    {
      var exam = _context.Exam.First(c => c.Id == id);
      if (exam != null)
      {
        _context.Exam.Remove(exam);
        _context.SaveChanges();
      }
    }
  }
}