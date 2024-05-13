using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Dapper.Core.Entities
{
    public class Marriage
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }

        public string statistic_yyy { get; set; } // 統計年度

        public string according { get; set; } // 按照別

        public string site_id { get; set; } // 區域別

        public int marry_count { get; set; } // 結婚人數
        public string marriage_type { get; set; } // 婚姻類型


        public string sex { get; set; } // 性別


        public string nation { get; set; } // 原屬國籍或地區

        public string edu { get; set; } // 教育程度

        public  string age { get; set; } // 年齡

        
    }
}
