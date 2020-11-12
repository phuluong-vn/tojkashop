using System;
using System.ComponentModel.DataAnnotations;

namespace Tojka.Model.Abstract
{
    public abstract class Auditable
    {
        public DateTime? CreateDate { get; set; }

        [MaxLength(256)]
        public string CreateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        [MaxLength(256)]
        public string UpdateBy { get; set; }

        [MaxLength(256)]
        public string MetaKeyword { get; set; }

        [MaxLength(256)]
        public string Description { get; set; }

        public bool Status { get; set; }
    }
}