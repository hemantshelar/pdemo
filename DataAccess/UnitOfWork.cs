using DataAccess.EFTableMappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UnitOfWork
    {
        private BloggerDbContext _bloggerDbContext = null;

        private RepositoryImpl<UserInfo> _UserInfoRepository = null;

        private RepositoryImpl<Blog> _BlogRepository = null;

        public RepositoryImpl<UserInfo> UserInfoRepository 
        {
            get
            {
                if (_UserInfoRepository == null)
                {
                    _UserInfoRepository = new RepositoryImpl<UserInfo>(_bloggerDbContext);
                }
                return _UserInfoRepository;
            }
        }

        public RepositoryImpl<Blog> BlogRepository 
        {
            get
            {
                if (_BlogRepository == null)
                {
                    _BlogRepository = new RepositoryImpl<Blog>(_bloggerDbContext);
                }
                return _BlogRepository;

            }
        }




        public UnitOfWork(BloggerDbContext _context)
        {
            _bloggerDbContext = _context;
        }

        public void Save()
        {
            if (_bloggerDbContext != null)
            {
                _bloggerDbContext.SaveChanges();
            }
        }
    }
}
