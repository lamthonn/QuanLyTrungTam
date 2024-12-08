<template>
<footer id="footer">
  <div class="f-col-1">
    <div>
      <div class="d-flex align-items-center">
        <div class="f-logo"><img src="../assets/footer/logoTeky.svg" alt=""></div>
        <ul class="list-linked">
          <li><a href=""><img src="../assets/footer/logo_CodeKitten.svg" alt=""></a></li>
          <li><a href=""><img src="../assets/footer/logo_toppy.svg" alt=""></a></li>
          <li><a href=""><img src="../assets/footer/logo_KittenJr2.svg" alt=""></a></li>
          <li><a href=""><img src="../assets/footer/logo_TutorO.svg" alt=""></a></li>
        </ul>
      </div>
      <p class="text-infor">TEKY là Học viện sáng tạo công nghệ với chương trình giảng dạy <strong>STEAM (Science
          – Technology – Engineering – Art – Mathematics)</strong> theo chuẩn Mỹ đầu tiên tại Việt Nam dành cho
          trẻ em từ 4 đến 18 tuổi.
      </p>
    </div>
    <div>
      <form class="input-group" action="/advise/email" id="advisory_subscribe_email_v3" method="POST" novalidate="novalidate">
        <input type="hidden" name="csrfmiddlewaretoken" value="Wpe5TCYgqZoGXz28YcMkZ0YovyV9THJnQrqzv6fVmV8qDtHGRMyTtcUYYsqLcBze">
        <div class="c-alert alert-success hidden" id="success_message" style="display:none"></div>
        <div class="form-register">
          <div class="form-text">
            <label class="register-label">Đăng ký nhận tin</label>
            <input class="form-input" type="email" name="email" placeholder="nhập email để nhận thông tin khuyến mại, cuộc thi...">
            <input type="hidden" name="tags" value="https://teky.edu.vn/">
          </div>
          <button type="submit" class="button-register"><img src="../assets/footer/iconFooter/icon-send.svg" alt=""></button>
        </div>
      </form>
  
      <div class="f-social">
        <div class="check-tb"><img src="../assets/footer/iconFooter/icon-check-TB.png" alt=""></div>
        <ul class="social-list">
          <li><a href="" target="_blank"><img src="../assets/footer/socialMedia/zalo.svg" alt=""></a></li>
          <li><a href="" target="_blank"><img src="../assets/footer/socialMedia/face.svg" alt=""></a></li>
          <li><a href="" target="_blank"><img src="../assets/footer/socialMedia/youtube.svg" alt=""></a></li>
          <li><a href="" target="_blank"><img src="../assets/footer/socialMedia/tiktok.svg" alt=""></a></li>
        </ul>
      </div>
    </div>
  </div>
  <div class="f-col-2">
    <h3 class="f-title">Dành cho Học sinh</h3>
    <ul class="f-menu">
      <li><i class="fa-solid fa-stop"></i><a href="/">Chơi &amp; Xem</a></li>
      <li><i class="fa-solid fa-stop"></i><a href="/hoc/">Học</a></li>
      <li><i class="fa-solid fa-stop"></i><a href="/lam-game/">Làm Game/dự án</a></li>
      <li><i class="fa-solid fa-stop"></i><a href="/cong-dong/">Cộng đồng</a></li>
      <li><i class="fa-solid fa-stop"></i><a href="/doi-qua/">Đổi quà</a></li>     
      <li><i class="fa-solid fa-stop"></i><a href="/login/">Hồ sơ của tôi</a></li>
      <li><i class="fa-solid fa-stop"></i><a href="/tro-giup/">Trợ giúp</a></li>
    </ul>
  </div>
  <div class="f-col-3">
    <h3 class="f-title">Dành cho Phụ huynh</h3>
    <ul class="f-menu">
      <li><i class="fa-solid fa-diamond"></i><a href="#">Về TEKY</a></li>
      <li><i class="fa-solid fa-diamond"></i><a href="#">Giải pháp giáo dục</a></li>
      <li><i class="fa-solid fa-diamond"></i><a href="#">Khóa học</a></li>
      <li><i class="fa-solid fa-diamond"></i><a href="#">Tuyển dụng</a></li>
      <li><i class="fa-solid fa-diamond"></i><a href="#">Blog</a></li>
      <li><i class="fa-solid fa-diamond"></i><a href="#">Khiếu nại</a></li>
      <li><i class="fa-solid fa-diamond"></i><a href="#">Liên hệ</a></li>
      <li><i class="fa-solid fa-diamond"></i><a href="#">Chính sách và Quy định</a></li>
      <li><i class="fa-solid fa-diamond"></i><a href="#">Chính sách bảo vệ thông tin</a></li>
    </ul>
  </div>
  <div class="f-col-4">
    <h3 class="f-title">Thông tin liên hệ</h3>
    <div class="info-row">
      <span class="info-icon"><img src="../assets/footer/iconFooter/icon-phone-2.svg" alt=""></span>
      <div class="info-cont">
        <ul class="list-hotline">
          <li>
            <label class="hotline-label">Tổng đài</label>
            <strong class="hotline-number">1900 3168</strong>
          </li>
          <li>
            <label class="hotline-label">Hotline lãnh đạo</label>
            <strong class="hotline-number">033 459 2016</strong>
          </li>
        </ul>
      </div>
    </div>
    <div class="info-row">
      <span class="info-icon"><img src="../assets/footer/iconFooter/icon-mail.svg" alt=""></span>
      <div class="info-cont"><strong>support</strong>@teky.edu.vn</div>
    </div>
    <div class="info-row">
      <span class="info-icon"><img src="../assets/footer/iconFooter/icon-location.svg" alt=""></span>
      <div class="info-cont">
        <p>
          <strong class="d-block">Trụ sở chính Miền Bắc</strong>
          <span class="addres-name">Tầng 5, Tòa nhà Mac Plaza Phường Mộ Lao, Quận Hà Đông, Hà Nội</span>
        </p>
        <p>
          <strong class="d-block">Trụ sở chính Miền Nam</strong>
          <span class="addres-name">152 Đ. Điện Biên Phủ, Phường 25, Bình Thạnh, Thành phố Hồ Chí Minh </span>
        </p>
      </div>
    </div>
    <div class="info-row">
      <span class="info-icon"><img src="../assets/footer/iconFooter/icon-office.svg" alt=""></span>
      <div class="info-cont"><a class="office-name" href="/phu-huynh/lien-he/">Danh sách toàn bộ học viện</a></div>
    </div>

    <address class="copyright">Copyright © 2016-2023 <strong>TEKY Holdings</strong>. All rights reserved.</address>
  </div>
</footer>
<!-- Footer -->

</template>

<script>
export default {
  name: "Footer-",
  components: {},

  setup() {},
};
</script>

<style>
img {
  border: none;
  outline: none;
  max-width: 100%;
}
a {
  color: black;
  transition: all ease 0.3s;
  text-decoration: none;
}

ul{
  list-style: none;
}
#footer{
  background-color: #fff;
  padding: 35px 30px 39px 35px;
  display: flex;
  justify-content: space-between;
  position: relative;
}

  #footer .f-col-1 {
    width: 29%;
    max-width: 375px;
    display: flex;
    flex-flow: column;
    justify-content: space-between;
  }
  .align-items-center {
    align-items: center!important;
  }

  .d-flex {
    display: flex!important;
  }

  #footer .f-col-1 .f-logo {
    width: 110px;
    margin-right: 7px;
  }
  #footer .f-col-1 .list-linked {
    display: flex;
    align-items: center;
    justify-content: space-evenly;
    padding: 0 6px;
    background-color: #DCF4EE;
    border-radius: 40px;
    flex: 1;
  }

  #footer .f-col-1 .list-linked li {
    padding: 12px 4px;
  }

  #footer .f-col-1 .text-infor {
    padding-top: 20px;
    font-weight: 500;
    text-align: justify;
    font-size: 14px;
  }
  .input-group {
    position: relative;
    display: flex;
    flex-wrap: wrap;
    align-items: stretch;
    width: 100%;
  }

  #footer .f-col-1 .form-register {
    width: 100%;
    height: 50px;
    border: 1px solid #D9D9D9;
    border-radius: 50px;
    padding: 0 20px;
    display: flex;
    justify-content: space-between;
    align-items: center;
    margin-bottom: 10px;
  }

  #footer .f-col-1 .form-register .form-text {
    flex: 1;
    font-size: 12px;
    position: relative;
    padding-bottom: 5px;
  }

  #footer .f-col-1 .form-register .form-text .register-label {
    font-weight: 700;
    display: block;
    margin-bottom: 0;
  }

  .form-text {
    display: block;
    margin-top: 0.25rem;
  }

  #footer .f-col-1 .form-register .form-text .form-input {
    background-color: transparent;
    padding: 0;
    border: none;
    width: 100%;
    font-weight: 500;
  }

  #footer .f-col-1 .form-register .button-register {
    margin-left: 20px;
    cursor: pointer;
    width: 20px;
    height: 20px;
    padding: 0;
    border: none;
    background-color: transparent;
  }

  #footer .f-col-1 .f-social {
    display: flex;
    justify-content: space-between;
    align-items: center;
  }

  #footer .f-col-1 .f-social .social-list {
    display: flex;
  }

  #footer .f-col-1 .f-social .social-list li {
    padding-left: 5px;
  }

  #footer .f-col-1 .f-social .social-list li a {
    display: block;
  }

  /*f-col-2*/ 
  #footer .f-col-2 {
    width: 14%;
    max-width: 180px;
  }

  #footer .f-title {
    font-size: 18px;
    font-weight: 700;
    margin-bottom: 30px;
  }
  #footer .f-menu li{
    display: flex;
  }
  #footer .f-menu li {
    margin-bottom: 20px;
  }

  #footer .f-menu li a {
    display: block;
    padding-left: 30px;
    font-weight: 100;
    font-size: 14px;
    color: black;
    line-height: 120%;
  }

  /*f-col-3*/ 
  #footer .f-col-3 {
    width: 14%;
    max-width: 180px;
  }


  /*f-col-4*/ 
  #footer .f-col-4 {
    width: 22%;
    max-width: 280px;
    font-weight: 100;
  }
  #footer .f-col-4 .info-row {
    margin-bottom: 22px;
    display: flex;
  }
  #footer .f-col-4 .info-row .info-icon {
    width: 18px;
    text-align: center;
    margin-right: 18px;
  }

  #footer .f-col-4 .info-row .info-cont {
    flex: 1;
    font-weight: 500;
    line-height: 120%;
  }
  #footer .f-col-4 .list-hotline {
    display: flex;
    padding-left: 0px;
  }
  #footer .f-col-4 .list-hotline li {
    line-height: 100%;
    /* padding: 0 38px; */
    width: 100%;
  }
  #footer .f-col-4 .list-hotline li:first-child {
    padding-left: 0;
    border-right: 1px solid #000;
  }
  #footer .f-col-4 .list-hotline li:last-child {
    padding-left: 20px;
  }

  #footer .f-col-4 .list-hotline li .hotline-label {
    margin-bottom: 0;
    display: block;
    font-size: 12px;
    font-weight: 500;
    margin-bottom: 5px;
  }

  #footer .f-col-4 .list-hotline li .hotline-number {
    display: block;
  }

  #footer .f-col-4 .copyright {
    font-size: 10px;
    font-weight: 500;
    margin-bottom: 0;
    font-style: normal;
  }
</style>
