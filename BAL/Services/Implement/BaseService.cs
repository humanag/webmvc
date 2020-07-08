using AutoMapper;
using BAL.Domain;
using DAL;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BAL.Services.Implement
{
    public abstract class BaseService<Tv, Te> : IBaseService<Tv, Te> where Tv : BaseDto
                                      where Te : BaseEntity
    {
        protected IUnitOfWork _unitOfWork;
        protected IMapper _mapper;

        protected BaseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            if (_unitOfWork == null)
                _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public virtual Task<Tv> Insert(Tv dto, int uid = 0)
        {
            var entity = _mapper.Map<Te>(source: dto);
            entity = _unitOfWork.GetRepository<Te>().Insert(entity, uid);
            _unitOfWork.Save();
            
            return Task.FromResult(_mapper.Map<Tv>(source: entity));
        }

        public virtual Task<bool> Delete(object id, int uid = 0)
        {
            var res = _unitOfWork.GetRepository<Te>().Delete(id, uid);
            if (res)
                _unitOfWork.Save();
            return Task.FromResult(res);
        }

        public virtual IEnumerable<Tv> GetAll(int uid = 0) 
        {
            var entities = _unitOfWork.GetRepository<Te>().GetAll(1, 20000, uid);
            return _mapper.Map<IEnumerable<Tv>>(source: entities);
        }

        public virtual IEnumerable<Tv> GetAll(string keyword, int uid = 0)
        {
            return GetAll(uid);
        }

        public virtual Task<bool> Update(Tv dto, int uid = 0)
        {
            var res = _unitOfWork.GetRepository<Te>().Update(dto.Id, _mapper.Map<Te>(source: dto), uid);
            _unitOfWork.Save();
            return Task.FromResult(res);
        }

        public IEnumerable<Tv> GetAll(Func<Te, bool> predicate, int uid = 0)
        {
            var entities = _unitOfWork.GetRepository<Te>().GetAll(predicate, uid);
            return _mapper.Map<IEnumerable<Tv>>(source: entities);
        }
    }
}
