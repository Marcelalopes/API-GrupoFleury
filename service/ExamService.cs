using System.Collections;
using API_GrupoFleury.models;
using System;
using System.Collections.Generic;
using System.Linq;
using API_GrupoFleury.Repository;
using API_GrupoFleury.Dtos;
using AutoMapper;
using System.Threading.Tasks;
using System.Dynamic;
using API_GrupoFleury.Enum;

namespace API_GrupoFleury.service
{
  public class ExamService : IExamService
  {
    private readonly IExamRepository _examRepository;
    private readonly IMapper _mapper;

    public ExamService(IExamRepository examRepository, IMapper mapper)
    {
      _examRepository = examRepository;
      _mapper = mapper;
    }
    public async Task<dynamic> GetAll(
      int pageNumber,
      int pageSize,
      string search,
      OrderByTypeEnum orderByType,
      OrderByColumnExamEnum orderByColumn
    )
    {
      var result = await _examRepository.GetAll(
        pageSize,
        pageNumber,
        search,
        orderByType,
        orderByColumn
      );
      dynamic response = new ExpandoObject();
      response.currentPage = pageNumber;
      response.pageSize = pageSize;
      response.totalPages = Math.Ceiling((double)result.TotalItemCount / pageSize);
      response.totalItems = result.TotalItemCount;
      response.search = search;
      response.orderByType = orderByType;
      response.orderByColumn = orderByColumn;

      response.data = _mapper.Map<IEnumerable<ExamsDto>>(result);


      return response;
    }
    public async Task<ExamNewDto> Add(ExamNewDto newExam)
    {
      var result = await _examRepository.add(_mapper.Map<Exam>(newExam));
      return _mapper.Map<ExamNewDto>(result);
    }
    public void Update(ExamUpdateDto updateExam)
    {
      _examRepository.Update(_mapper.Map<Exam>(updateExam));
    }
    public Boolean Delete(Guid id)
    {
      return _examRepository.Delete(id);
    }
  }
}