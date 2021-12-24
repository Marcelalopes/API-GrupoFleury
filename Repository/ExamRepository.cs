using System;
using System.Collections.Generic;
using API_GrupoFleury.models;
using API_GrupoFleury.Context;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API_GrupoFleury.Repository
{
  public class ExamRepository : IExamRepository
  {
    private readonly AppDbContext _context;

    public ExamRepository(AppDbContext context)
    {
      _context = context;
    }

    public async Task<Exam> add(Exam exam)
    {
      var result = await _context.Exam.AddAsync(exam);
      _context.SaveChanges();
      return result.Entity;
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

    public async Task<IEnumerable<Exam>> GetAll()
    {
      return await _context.Exam.ToListAsync();
    }

    public void Update(Exam exam)
    {
      _context.Exam.Update(exam);
      _context.SaveChanges();
    }
  }
}