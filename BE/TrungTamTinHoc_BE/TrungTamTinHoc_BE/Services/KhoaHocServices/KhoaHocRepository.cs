﻿using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrungTamTinHoc_BE.Data;
using TrungTamTinHoc_BE.Data.KhoaHoc_VM;
using TrungTamTinHoc_BE.Models;

namespace TrungTamTinHoc_BE.Services.KhoaHocServices
{
    public class KhoaHocRepository : IKhoaHocRepository
    {
        public readonly AppDbContext _context;
        public KhoaHocRepository(AppDbContext context) 
        { 
            _context = context;
        }

        public List<KhoaHoc_VM> getAllKhoaHoc(KhoaHocQuery request)
        {
            var KhoaHoc_Loai = _context.KhoaHocs.AsNoTracking();
            if (request.Loai != null)
            {
                KhoaHoc_Loai = _context.KhoaHocs.Where(re => re.Loai == request.Loai);
            }
            var result = KhoaHoc_Loai.Select(k => new KhoaHoc_VM
            {
                maKH = k.maKH,
                tenKH = k.tenKH,
                description = k.description,
                luaTuoi = k.luaTuoi,
                price = k.price,
                rate = k.rate,
                pathImage = k.pathImage,
                maGV = k.maGV,
                Loai = k.Loai
            }).ToList();
            return result;
        }

        public KhoaHoc_VM getKhoaHocByMaKH([FromRoute]string maKH)
        {
            var result = _context.KhoaHocs.SingleOrDefault(x =>  x.maKH == maKH);
            if(result != null)
            {
                var data = new KhoaHoc_VM
                {
                    maKH = result.maKH,
                    tenKH = result.tenKH,
                    description = result.description,
                    Loai = result.Loai,
                    luaTuoi = result.luaTuoi,
                    price = result.price,
                    maGV = result.maGV,
                    pathImage = result.pathImage,
                    rate = result.rate,
                };
                return data;
            }
            else
            {
                return null;
            }
        }

        public KhoaHoc_VM addKhoaHoc(KhoaHoc_VM khoahoc)
        {
            var newKhoaHoc = new KhoaHoc
            {
                maKH = khoahoc.maKH,
                tenKH = khoahoc.tenKH,
                description = khoahoc.description,
                luaTuoi = khoahoc.luaTuoi,
                price = khoahoc.price,
                rate = khoahoc.rate,
                Loai = khoahoc.Loai,
                pathImage = khoahoc.pathImage,
                maGV = khoahoc.maGV
            };
            _context.KhoaHocs.Add(newKhoaHoc);
            _context.SaveChanges();
            return new KhoaHoc_VM
            {
                maKH = newKhoaHoc.maKH,
                tenKH = newKhoaHoc.tenKH,
                description = newKhoaHoc.description,
                luaTuoi = newKhoaHoc.luaTuoi,
                price = newKhoaHoc.price,
                rate = newKhoaHoc.rate,
                Loai = khoahoc.Loai,
                pathImage = newKhoaHoc.pathImage,
                maGV = newKhoaHoc.maGV
            };
        }

        public void updateKhoaHoc(string maKH, KhoaHoc_VM khoaHoc)
        {
            var result = _context.KhoaHocs.SingleOrDefault(r => r.maKH ==  maKH);
            if (result != null)
            {
                result.tenKH = khoaHoc.tenKH;
                result.description = khoaHoc.description;
                result.luaTuoi = khoaHoc.luaTuoi;
                result.price = khoaHoc.price;
                result.rate = khoaHoc.rate;
                result.Loai = khoaHoc.Loai;
                result.maGV = khoaHoc.maGV;
                _context.KhoaHocs.Update(result);
                _context.SaveChanges();
            }
            
        }

        public void deleteKhoaHoc(string maKH)
        {
            var result = _context.KhoaHocs.SingleOrDefault(r => r.maKH == maKH);
            if (result != null)
            {
                _context.Remove(result);
                _context.SaveChanges();
            }
            else { _context.SaveChanges(); }
            
        }

        public List<PaymentRc> CheckPayment(string username)
        {
            var data = _context.paymentRecords.Where(x => x.UserId == username)
                .Select(x => new PaymentRc
                {
                    khoaHocId = x.KhoaHocId,
                    khoaHoc = _context.KhoaHocs.FirstOrDefault(y => y.maKH == x.KhoaHocId)!.tenKH,
                }).ToList();
            return data;
        }
    }
}
