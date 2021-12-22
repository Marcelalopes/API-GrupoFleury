using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using API_GrupoFleury.Context;
using System.Linq;

namespace API_GrupoFleury.Repository
{
  public class ExamRepository : IExamRepository
  {
    private readonly AppDbContext _context;

    public ExamRepository(AppDbContext context)
    {
      _context = context;
    }

    public void add(Exam exam)
    {
      _context.Exam.Add(exam);
      _context.SaveChanges();
    }

    public bool Delete(Guid id)
    {
      var exam = _context.Exam.FirstOrDefault(e => e.Id == id);

      if (exam == null)
        return false;

      _context.Exam.Remove(exam);
      _context.SaveChanges();
      return true;
    }

    public IEnumerable<Exam> GetAll()
    {
      return _context.Exam.ToList();
    }

    public void Update(Exam exam)
    {
      _context.Exam.Update(exam);
      _context.SaveChanges();
    }
  }
}