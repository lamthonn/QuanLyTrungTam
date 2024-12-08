<template>
    <CourseRegister ref="xemRef"/>
    <div id="detailCourse" class="product-detial-page">
        <div class="product-banner" >
        <ul class="breadcrumb-list">
            <li><a href="/phu-huynh/danh-sach-khoa-hoc/">Trang chủ</a></li>
            <li><a href="#">Sản phẩm</a></li>
            <li>{{ dataByMaKH.tenKH }}</li>
        </ul>
        <div class="product-wrap">
            <div class="product-introduce">
                <h2 class="product-name">{{ dataByMaKH.tenKH }}</h2>
                <p class="mb-0">{{ dataByMaKH.description }}</p>
            </div>
            <div class="product-prize">
                    <div class="prize-view">
                        <div class="view-user">
                            <div class="user-thumb"><img src="@/assets/Courses/3D_ART/DetailCourse/product-detail-user-1.png" alt=""></div>
                            <div class="user-thumb"><img src="@/assets/Courses/3D_ART/DetailCourse/product-detail-user-2.png" alt=""></div>
                            <div class="user-thumb"><img src="@/assets/Courses/3D_ART/DetailCourse/product-detail-user-3.png" alt=""></div>
                        </div>
                        <span class="view-label">+3152 Bạn đã học </span>
                    </div>
                    <div class="course-prize">
                        <span class="prize-poin">{{ dataByMaKH.rate }}</span>
                        <div class="prize-star">
                            <i class="icon12-star"></i><i class="icon12-star"></i><i class="icon12-star"></i><i class="icon12-star"></i><i class="icon12-star-half"></i>                   
                        </div>
                        <span class="prize-total">(2543)</span>
                    </div>
                    <img src="" alt="">
            </div>
        </div>
        </div>
        <div class="product-detail-wrap">
            <div class="product-detail">
                <div class="description-box">
                    <div class="head-page">
                        <h2 class="page-title"><span class="text-green">#</span>Mô tả khóa học</h2>
                    </div>
                    <div class="description-video">
                        <iframe src="https://player.vimeo.com/video/716726436" frameborder="0" allow="autoplay; fullscreen" allowfullscreen="" width="100%" style="min-height: 300px"></iframe>
                    </div>
                    <ul class="list-detail">
                        <ul>
                            <li>Tạo hình 3D là một lĩnh vực vô cùng rộng mở trong thời đại công nghệ số hiện nay. Những định dạng hình ảnh 3 chiều xuất hiện trên phim ảnh, những sản phẩm In 3D là công nghệ chỉ mới xuất hiện cách đây 40 năm, nhưng nó đang được ứng dụng trong mọi lĩnh vực của đời sống con người: từ những vật dụng đơn giản sử dụng trong gia đình, đồ chơi cho trẻ em, đồ trang sức đến những ứng dụng trong các lĩnh vực nghệ thuật, kiến trúc, công nghiệp ô tô, công nghệ vũ trụ, công nghệ chế tạo robot, y học, và nghệ thuật. Máy in 3D cho phép chúng ta hiện thực hóa mọi khái niệm trừu tượng thành một vật thể cụ thể.</li>
                            <li>Trước khi tiếp cận vào In 3D, học sinh sẽ làm quen với Bút 3D - phiên bản cầm tay của một chiếc máy in 3D, cho phép người dùng tự do và linh hoạt hơn so với in 3D trong việc sáng tạo về để tạo ra bất cứ thứ gì mà họ mơ về. Khóa học công nghệ in/vẽ 3D của Teky tạo cơ hội cho học sinh Việt Nam trải nghiệm một trong những phương pháp học STEM có tính trực quan, sáng tạo cao đang được áp dụng ở những nền giáo dục tiên tiến nhất thế giới như Mỹ, Hong Kong, Singapore…. - Sau các học kì tìm hiểu về hình khối và áp dụng xây dựng sản phẩm bằng công nghệ in/vẽ 3D, các bạn học sinh sẽ kết hợp với công nghệ thực tế ảo để đem các sản phẩm các bạn đã thiết kế vào không gian 3 chiều. Thực tế ảo hay còn gọi là thực tại ảo (tiếng Anh là virtual reality, viết tắt là VR) là thuật ngữ miêu tả một môi trường được giả lập (ảo hóa) được tạo ra bởi con người nhờ vào các phần mềm chuyên dụng, và được điều khiển bởi một thiết bị thông minh.Ngoài việc tạo ra không gian ảo, công nghệ thực tế ảo VR còn có thể tương tác thực tế với người dùng qua cử chỉ và nhiều giác quan khác nhau như: Thính giác, khứu giác và xúc giác. Trong thế giới thực tế ảo, các bạn học sinh có thể tùy ý sáng tạo nên thế giới của mình, kết hợp với các kiến thức lập trình để các vật thể trong không gian 3 chiều có thể tương tác với người dùng. Từ đó thế giới ảo sẽ trở nên sinh động, mới mẻ và không giới hạn về sự sáng tạo</li>
                        </ul>
                        <h3>VIDEO GIỚI THIỆU CÔNG CỤ&nbsp;</h3>
                        <h4>Video giới thiệu công cụ 3d Pen</h4>
                        <div class="embed-responsive embed-responsive-16by9"><iframe allowfullscreen="" class="embed-responsive-item" src="https://www.youtube.com/embed/w0s9tWLHJ24"></iframe></div>
                        <h4>Video giới thiệu công cụ Maker Empire</h4>
                        <div class="embed-responsive embed-responsive-16by9"><iframe allowfullscreen="" class="embed-responsive-item" src="https://www.youtube.com/embed/M_u9kpKZXvU"></iframe></div>
                        <h4>Video giới thiệu công cụ Tinkercad</h4>
                        <div class="embed-responsive embed-responsive-16by9"><iframe allowfullscreen="" class="embed-responsive-item" src="https://www.youtube.com/embed/LrU2zm_g7lE"></iframe></div>
                        <h4>Video giới thiệu công cụ Cospace</h4>
                        <div class="embed-responsive embed-responsive-16by9"><iframe allowfullscreen="" class="embed-responsive-item" src="https://www.youtube.com/embed/zUR9i60zLo8"></iframe></div>
                        <h3>THỜI ĐẠI 4.0, TRẺ EM PHẢI HỌC LẬP TRÌNH</h3>
                        <h4>Vì sao trẻ em nên học lập trình?</h4>
                        <!-- {{ dataByMaKH.description }} -->
                        <ul>
                            <li>Anh, Mỹ, Trung Quốc, HongKong, Singapore, Nhật v.v.. đều bắt buộc học lập trình từ lớp 1.</li>
                            <li>Trên 100 triệu học sinh từ 7 tuổi đã học lập trình trên nền tảng Scratch (MIT, Mỹ), Minecraft (Microsoft) v.v…</li>
                            <li>Trong thời đại số, kỷ nguyên của Robot và Trí tuệ nhân tạo, Công nghệ và lập trình mới là ngôn ngữ chung của nhân loại. Đừng để con “mù chữ” thời số.</li>
                        </ul>
                        <h4>Cam kết của học viện Teky</h4>
                        <ul>
                            <li>7 tuổi có thể lập trình Game với nền tảng lập trình scratch, phần mềm sau 24h.</li>
                            <li>98% trẻ em được khơi dậy đam mê học công nghệ chỉ sau 2h học thử miễn phí.</li>
                            <li>Chuyển biến hành vi nghiện game, máy tính thành đam mê học và sáng tạo công nghệ.</li>
                            <li>Hỗ trợ học tập hiệu quả các bộ môn Toán học, vật lý, khoa học và xã hội.</li>
                            <li>Tư duy lập trình, thiết kế, logic và hệ thống; năng lực hiện thực hoá ý tưởng và các kỹ năng thế kỷ 21</li>
                        </ul>
                        <h4>Vì sao lựa chọn Teky?</h4>
                        <ul>
                            <li>1 trong 16 Dự án Đổi mới giáo dục tiêu biểu toàn cầu - Theo báo cáo của diễn đàn Kinh tế thế giới WEF 2020 tại Davos, Thụy Sĩ.</li>
                            <li>Chương trình học duy nhất ở Việt Nam được thẩm định chất lượng quốc tế bởi Liên đoàn các nhà giáo đổi mới Phần Lan EAF</li>
                            <li>Dự án có ảnh hưởng xã hội tốt nhất tại Đông Nam Á&nbsp;bởi Chính phủ Úc và Giải thưởng Rice Bowl Đông Nam Á – Global Startup Awards, Asean Business Award.</li>
                            <li>Giải pháp EduTech xuất sắc Châu Á 2019 trao tại Singapore.&nbsp;</li>
                            <li>Nhà tổ chức cuộc thi lập trình nhí quy mô nhất châu Á – Minecraft Hackathon và Codekitten, hợp tác cùng Microsoft, Trung Ương Đoàn Thanh niên Cộng sản Hồ Chí Minh.&nbsp;</li>
                            <li>Học sinh có nhiều thành tích, huy chương trong các cuộc thi lập trình &amp; Robotics trong nước và quốc tế như HKICO, WeCode Đông Nam Á, App Jamming Asia Summit – cuộc thi lập trình App Châu Á; lập trình Robot First LEGO League, World Robot Olympiad, Sáng tạo trẻ tại Việt Nam, Tin học trẻ không chuyên v.v..</li>
                            <li>Giáo trình đào tạo chuẩn Mỹ, xây dựng bởi đội ngũ chuyên gia và cố vấn giáo dục trong nước, quốc tế.</li>
                            <li>Trang thiết bị hiện đại, giảng viên chất lượng cao, ứng dụng công nghệ giúp học tập công nghệ hiệu quả</li>
                            <li>Tới tháng 3/2022, 100.000 học sinh đã tham gia học lập trình và công nghệ qua hình thức Online hoặc trực tiếp tại các học viện&nbsp;Teky</li>
                        </ul>
                    </ul>
                </div>
                <div class="students-learn">
                    <div class="head-page">
                        <h2 class="page-title"><span class="text-green">#</span>Học sinh học được gì?</h2>
                    </div>
                    <div class="group-information">                    
                        <div class="information-col">
                            <strong class="m-title">Phát triển Tư duy &amp; khái niệm</strong>
                            <ul class="list-detail">
                                
                                <ul>
                        <li>Tư duy thiết kế, dựng hình</li>
                        <li>Các khái niệm về hình học, toán học và sự kết hợp của các hình khối trong tạo hình</li>
                        <li>Cấu trúc của các vật thể và kiến trúc đơn giản.</li>
                        <li>Các khái niệm cơ bản về điện tử và lập trình với mạch Microbit.</li>
                    </ul>
                                
                            </ul>
                        </div>                   
                        <div class="information-col">
                            <strong class="m-title">Kỹ năng phần cứng, phần mềm</strong>
                            <ul class="list-detail">
                                <ul>
                                    <li>Phần mềm: Maker Empire, Stop Motion Studio, TinkerCAD, CoSpaces</li>
                                    <li>Phần cứng: Microbit, Bút 3D, Máy in 3D, thiết bị AR/VR</li>
                                </ul>
                            </ul>
                        </div>
                        <div class="information-col">
                            <strong class="m-title">Kiến thức</strong>
                            <ul class="list-detail">                               
                                <ul>
                                    <li>Hiểu kỹ thuật dựng hình cơ bản tới hình đa giác và đường cong thông qua bút vẽ 3D</li>
                                    <li>Tìm hiểu điện tử và cơ chế truyền động, kết cấu các mạch cơ bản thông qua mạch Microbit</li>
                                    <li>Các kỹ thuật dựng hình trong không gian 3 chiều với môi trường Tinkercad.</li>
                                    <li>Thiết lập quy trình vẽ, in 3D.</li>
                                </ul>                               
                            </ul>
                        </div>                   
                        <div class="information-col">
                            <strong class="m-title">Kỹ năng thế kỷ 21</strong>
                            <ul class="list-detail">                                
                                <ul>
                                    <li>Lập kế hoạch dự án và thiết kế kỹ thuật</li>
                                    <li>Tư duy thực hiện quy trình thiết kế.</li>
                                    <li>Kỹ năng giao tiếp (Communication): Thông qua hoạt động trình bày, truyền đạt ý tưởng dưới dạng nói và viết</li>
                                    <li>Tư duy phản biện (Critical Thinking): Thông qua việc tự tin nói lên quan điểm và các lập luận cá nhân.</li>
                                    <li>Năng lực sáng tạo (Creativity): Thông qua sáng tạo sản phẩm mới mẻ và hiện thực hoá, học sinh được đóng nhiều vai trò của lập trình viên, nhà sản xuất, người kể chuyện, nhà thiết kế, nhà soạn nhạc</li>
                                    <li>Kỹ năng hợp tác (Collaboration): Thông qua việc chia sẻ hiểu biết cho nhau, cộng tác, làm việc theo nhóm, hợp tác hoặc phản biện để nâng cao hiệu quả.</li>
                                </ul>                               
                            </ul>
                        </div>
                    </div>
                </div>
                <div class="armorial-box">
                    <div class="head-page">
                        <h2 class="page-title"><span class="text-green">#</span>Chứng chỉ/Huy hiệu</h2>
                    </div>
                    <p class="armorial-guide">Chứng chỉ cấp bởi Teky và các đối tác; Nội dung giáo trình theo bản quyền của Teky với sự phát triển biển tập bởi đội ngũ học thuật chất lượng cao của Teky </p>
                    <ul class="armorial-list">                       
                        <li><img style="max-width: 64px;max-height: 64px;" src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/course_sections/badges/2.Digigirl_hp1.png" data-toggle="tooltip" data-html="true" title="" data-original-title="Bạn cần hoàn thành <strong class='text-warning'><b>Học phần 1 - 3D PEN &amp; MICROBIT</b></strong> để được nhận huy hiệu này"></li>                       
                        <li><img style="max-width: 64px;max-height: 64px;" src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/course_sections/badges/2.Digigirl_hp2.png" data-toggle="tooltip" data-html="true" title="" data-original-title="Bạn cần hoàn thành <strong class='text-warning'><b>Học phần 2 - 3D PEN &amp; MICROBIT</b></strong> để được nhận huy hiệu này"></li>
                        <li><img style="max-width: 64px;max-height: 64px;" src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/course_sections/badges/2.Digigirl_hp3.png" data-toggle="tooltip" data-html="true" title="" data-original-title="Bạn cần hoàn thành <strong class='text-warning'><b>Học phần 3 - 3D PRINTING &amp; MODELLING, MAKER EMPIRE</b></strong> để được nhận huy hiệu này"></li>
                        <li><img style="max-width: 64px;max-height: 64px;" src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/course_sections/badges/2.Digigirl_hp4.png" data-toggle="tooltip" data-html="true" title="" data-original-title="Bạn cần hoàn thành <strong class='text-warning'><b>Học phần 4 - 3D PRINTING &amp; MODELLING, MAKER EMPIRE</b></strong> để được nhận huy hiệu này"></li>
                        <li><img style="max-width: 64px;max-height: 64px;" src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/course_sections/badges/2.Digigirl_hp5.png" data-toggle="tooltip" data-html="true" title="" data-original-title="Bạn cần hoàn thành <strong class='text-warning'><b>Học phần 5 - 3D PRINTING &amp; MODELLING, TINKERCAD</b></strong> để được nhận huy hiệu này"></li>            
                        <li><img style="max-width: 64px;max-height: 64px;" src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/course_sections/badges/2.Digigirl_hp6.png" data-toggle="tooltip" data-html="true" title="" data-original-title="Bạn cần hoàn thành <strong class='text-warning'><b>Học phần 6 - 3D PRINTING &amp; MODELLING, TINKERCAD</b></strong> để được nhận huy hiệu này"></li>      
                        <li><img style="max-width: 64px;max-height: 64px;" src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/course_sections/badges/2.Digigirl_hp7.png" data-toggle="tooltip" data-html="true" title="" data-original-title="Bạn cần hoàn thành <strong class='text-warning'><b>Học phần 7 - 3D PRINTING &amp; MODELLING, TINKERCAD</b></strong> để được nhận huy hiệu này"></li>                    
                        <li><img style="max-width: 64px;max-height: 64px;" src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/course_sections/badges/2.Digigirl_hp8.png" data-toggle="tooltip" data-html="true" title="" data-original-title="Bạn cần hoàn thành <strong class='text-warning'><b>Học phần 8 - 3D PRINTING &amp; MODELLING, TINKERCAD</b></strong> để được nhận huy hiệu này"></li>
                        <li><img style="max-width: 64px;max-height: 64px;" src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/course_sections/badges/2.Digigirl_hp9.png" data-toggle="tooltip" data-html="true" title="" data-original-title="Bạn cần hoàn thành <strong class='text-warning'><b>Học phần 9 - VR/AR &amp; Cospaces</b></strong> để được nhận huy hiệu này"></li>                      
                        <li><img style="max-width: 64px;max-height: 64px;" src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/course_sections/badges/2.Digigirl_hp10.png" data-toggle="tooltip" data-html="true" title="" data-original-title="Bạn cần hoàn thành <strong class='text-warning'><b>Học phần 10 - VR/AR &amp; Cospaces</b></strong> để được nhận huy hiệu này"></li>                   
                        <li><img style="max-width: 64px;max-height: 64px;" src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/course_sections/badges/2.Digigirl_hp11.png" data-toggle="tooltip" data-html="true" title="" data-original-title="Bạn cần hoàn thành <strong class='text-warning'><b>Học phần 11 - VR/AR &amp; Cospaces</b></strong> để được nhận huy hiệu này"></li>
                        <li><img style="max-width: 64px;max-height: 64px;" src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/course_sections/badges/2.Digigirl_hp12.png" data-toggle="tooltip" data-html="true" title="" data-original-title="Bạn cần hoàn thành <strong class='text-warning'><b>Học phần 12 - VR/AR &amp; Cospaces</b></strong> để được nhận huy hiệu này"></li>
                    </ul>
                </div>
                <div class="tools-box">
                    <div class="head-page">
                    <h2 class="page-title"><span class="text-green">#</span>Thiết bị &amp; Công cụ học tập</h2>
                    <div class="tools-control">
                        <button class="btn-tools-prev slick-arrow slick-disabled" aria-disabled="true" style=""><img src="/static/web/v3/img/icon/arrow-tools-left.svg" alt=""></button>
                        <button class="btn-tools-next slick-arrow" style="" aria-disabled="false"><img src="/static/web/v3/img/icon/arrow-tools-left.svg" alt=""></button>
                    </div>
                    </div>
                    <div class="slider tools-slider slick-initialized slick-slider"><div class="slick-list draggable"><div class="slick-track" style="opacity: 1; width: 2148px; transform: translate3d(0px, 0px, 0px);"><div class="slick-slide slick-current slick-active" data-slick-index="0" aria-hidden="false" style="width: 179px;"><div><div class="items" style="width: 100%; display: inline-block;"><img src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/learning_equipment/2022/04/28/laptop.png"></div></div></div><div class="slick-slide slick-active" data-slick-index="1" aria-hidden="false" style="width: 179px;"><div><div class="items" style="width: 100%; display: inline-block;"><img src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/learning_equipment/2022/04/28/microbit.png"></div></div></div><div class="slick-slide slick-active" data-slick-index="2" aria-hidden="false" style="width: 179px;"><div><div class="items" style="width: 100%; display: inline-block;"><img src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/learning_equipment/2022/04/28/xyz-print.png"></div></div></div><div class="slick-slide slick-active" data-slick-index="3" aria-hidden="false" style="width: 179px;"><div><div class="items" style="width: 100%; display: inline-block;"><img src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/learning_equipment/2022/04/28/ipad.png"></div></div></div><div class="slick-slide slick-active" data-slick-index="4" aria-hidden="false" style="width: 179px;"><div><div class="items" style="width: 100%; display: inline-block;"><img src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/learning_equipment/2022/04/29/3d_pen.png"></div></div></div><div class="slick-slide slick-active" data-slick-index="5" aria-hidden="false" style="width: 179px;"><div><div class="items" style="width: 100%; display: inline-block;"><img src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/projects/tools/2022/04/29/Robot_Thumbnail_Resized-e1574666381369.png"></div></div></div><div class="slick-slide" data-slick-index="6" aria-hidden="true" style="width: 179px;" tabindex="-1"><div><div class="items" style="width: 100%; display: inline-block;"><img src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/projects/tools/2022/03/01/CoSpaces_Logo.svg.png"></div></div></div><div class="slick-slide" data-slick-index="7" aria-hidden="true" style="width: 179px;" tabindex="-1"><div><div class="items" style="width: 100%; display: inline-block;"><img src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/projects/tools/2022/03/01/makecode.png"></div></div></div><div class="slick-slide" data-slick-index="8" aria-hidden="true" style="width: 179px;" tabindex="-1"><div><div class="items" style="width: 100%; display: inline-block;"><img src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/projects/tools/2022/03/01/maker_empire.png"></div></div></div><div class="slick-slide" data-slick-index="9" aria-hidden="true" style="width: 179px;" tabindex="-1"><div><div class="items" style="width: 100%; display: inline-block;"><img src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/projects/tools/2022/03/01/microbit.png"></div></div></div><div class="slick-slide" data-slick-index="10" aria-hidden="true" style="width: 179px;" tabindex="-1"><div><div class="items" style="width: 100%; display: inline-block;"><img src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/projects/tools/2022/03/01/tinkercad.png"></div></div></div><div class="slick-slide" data-slick-index="11" aria-hidden="true" style="width: 179px;" tabindex="-1"><div><div class="items" style="width: 100%; display: inline-block;"><img src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/projects/tools/2022/03/01/xyz-print.png"></div></div></div></div></div></div>
                </div>
                <div class="rule-learn">
                    <div class="head-page">
                    <h2 class="page-title"><span class="text-green">#</span>Nguyên tắc giảng dạy</h2>
                    </div>
                    <div class="group-information">
                    <div class="information-col">
                        <div class="mb-3">
                        <strong class="d-block">Lớp học tiêu chuẩn 8 học sinh 1 giảng viên</strong>
                        <div>Nhằm gia tăng hiệu quả học tập</div>
                        </div>
                        <div class="mb-3">
                        <strong class="d-block">Lấy học sinh làm trọng tâm</strong>
                        <div>Giáo viên đóng vai trò là huấn luyện viên, theo sát năng lực học tập của từng học sinh.</div>
                        </div>
                    </div>
                    <div class="information-col">
                        <div class="mb-3">
                        <strong class="d-block">Mô hình học tập theo dự án (Project Based Learning)</strong>
                        <div>Sản phẩm được dựa trên các vấn đề và thực tế cuộc sống, hiện thực hoá từ ý tưởng thành sản phẩm.</div>
                        </div>
                        <div class="mb-3">
                        <strong class="d-block">Tích hợp kỹ năng 4C (Communication - Critical Thinking - Creativity - Collaboration)</strong>
                        <div>Trong hoạt động của mọi lớp học, giờ học.</div>
                        </div>
                    </div>
                    </div>
                </div>
            </div>
            <div class="sidebar-register">
                <div class="form-register">
                    <div class="course-price">
                    <label class="price-label">Chỉ từ</label>
                    <div class="price"><strong>{{ dataByMaKH.price }}</strong>.000</div>
                    <div class="unit"><sup class="unit-label">đ</sup>/giờ</div>
                    </div>
                    <a class="btn btn-animation btn-register  is-learn-try" href="#" data-toggle="modal" data-target="#modalRegisterOnline" data-course_id="874" @click="showModalRegister"><span><strong>Đăng ký học</strong></span></a>
                    <div class="space-or"><span>Hoặc</span></div>
                    <button class="btn btn-call"><span>Gọi ngay để tư vấn</span></button>
                    <div class="form-group">
                    <label class="form-label"></label>
                    <strong class="form-text"></strong>
                    </div>
                    
                    <div class="form-group">
                        <label class="form-label">Độ tuổi</label>
                        <strong class="form-text">{{ dataByMaKH.luaTuoi }} tuổi</strong>
                    </div>
                    
                    
                    <div class="form-group">
                        <label class="form-label">Học phần</label>
                        <strong class="form-text">12 học phần từ thấp đến cao</strong>
                    </div>
                    
                    
                    <div class="form-group">
                        <label class="form-label">Thời lượng</label>
                        <strong class="form-text">288 giờ (3 học kỳ ~ 36 tháng), 120' mỗi buổi</strong>
                        </div>
                    
                    
                    <div class="form-group">
                        <label class="form-label">Lớp tiêu chuẩn</label>
                        <strong class="form-text">16 học sinh</strong>
                        </div>
                    
                    
                    <div class="form-group">
                        <label class="form-label">Điều kiện để học</label>
                        <strong class="form-text"><p>Không</p></strong>
                        </div>
                    
                    
                    <div class="form-group">
                        <label class="form-label">Công cụ</label>
                        <strong class="form-text">MODELLING, MAKER EMPIRE, TINKERCAD</strong>
                        </div>
                    
                    
                    <div class="form-group">
                        <label class="form-label">Giáo trình</label>
                        <strong class="form-text"><p>Bản quyền và chứng nhận học công nghệ của&nbsp;Teky</p></strong>
                        </div>
                    
                
            
                </div>
                
                
                <div id="banner-parent" class="banner-teky-v3" style="width: 100%; height: auto; margin-top: 20px;">
                        <a href="https://teky.edu.vn/dang-ky-hoc/">
                            <img src="https://sgp1.digitaloceanspaces.com/teky-prod/teky-edu-vn/media/banners/2023/1101/Visual_Th%C3%A1ng_11_size_web.png" alt="" sizes="" srcset="" style="width: 100%;;border-radius:20px;height:auto;">
                        </a>
                </div>
                
            </div>
        </div>
    </div>
    
</template>

<script>
import { ref } from 'vue'
import { useRouter } from 'vue-router';
import axios from 'axios';
import { notification } from 'ant-design-vue';
import CourseRegister from './CourseRegister.vue';
export default {
    name: "detailCourse-",
    components:{
        CourseRegister
    },
    setup(){
        const xemRef = ref();
        const router = useRouter();
        const dataByMaKH = ref([]);
        console.log(dataByMaKH);

        const showModalRegister = () => {
            xemRef.value.visible = true;
        }
        return {
            router,
            dataByMaKH,
            xemRef,
            showModalRegister
        }
    },
    mounted(){
        const MaKH = this.$route.params.maKH;
        const getData = async () => {
            await axios.get(`https://localhost:7255/api/KhoaHoc/${MaKH}`)
                    .then(async res => this.dataByMaKH = res.data)
                    .catch((err)=>{
                        notification.open({
                            message: `${err}`,
                            onClick: () => {
                                console.log('Notification Clicked!');
                            },
                            });
                    })
        }
        getData();
    }
}
</script>

<style scoped>
#detailCourse{
    width: 100%;
    max-width: 1500px;
    padding: 0 30px;
    margin: 0 auto;
}
    .product-detial-page .product-banner {
    background: url("@/assets/Courses/3D_ART/DetailCourse/DigiGirlz.png") no-repeat 50% 50%;
    background-size: cover;
    border-radius: 30px;
    height: 300px;
    overflow: hidden;
    position: relative;
    padding-right: 400px;
    padding-left: 30px;
    color: #fff;
    font-size: 18px;
    display: flex;
    justify-content: center;
    flex-flow: column;
    }

    .product-detial-page .product-banner .breadcrumb-list {
    display: flex;
    align-items: center;
    margin-bottom: 40px;
    flex-flow: wrap;
    padding-top: 60px;
    }
    .product-detial-page .product-banner > * {
    position: relative;
    z-index: 3;
    }
    .product-detial-page .product-banner .breadcrumb-list li {
    font-weight: 400;
    padding-right: 10px;
}
.product-detial-page .product-banner .breadcrumb-list li a {
    color: #fff;
    font-weight: 700;
}

.product-detial-page .product-banner .product-wrap {
    display: flex;
    justify-content: space-between;
    flex-flow: wrap;
}

.product-detial-page .product-banner .product-wrap .product-introduce {
    width: calc(100% - 220px);
    padding-right: 100px;
}

.product-detial-page .product-banner .product-wrap .product-introduce .product-name {
    font-size: 22px;
    font-weight: 700;
    margin-bottom: 9px;
}

.product-detial-page .product-banner .product-wrap .product-prize {
    width: 220px;
}
.product-detial-page .product-banner .product-wrap .product-prize .course-prize .prize-poin {
    color: #FCF055;
}

.product-detial-page .product-banner .product-wrap .product-prize .course-prize .prize-star {
    display: flex;
    padding: 0 8px 0 4px;
}

.product-detial-page .product-banner .product-wrap .product-prize .course-prize .prize-total {
    color: #fff;
}

.product-detial-page .product-banner::before {
    content: "";
    width: 100%;
    height: 100%;
    background: rgba(0, 0, 0, 0.7);
    position: absolute;
    left: 0;
    top: 0;
}
.product-detial-page .product-banner .product-wrap .product-prize .prize-view {
    display: flex;
    justify-content: flex-end;
    align-items: center;
}
.product-detial-page .product-banner .product-wrap .product-prize .prize-view .view-user {
    display: flex;
}

.prize-view .view-user img{
    border-radius: 20px;
}

.product-detial-page .product-banner .product-wrap .product-prize .course-prize {
    display: flex;
    align-items: center;
    justify-content: flex-end;
    font-weight: 700;
    font-size: 12px;
}

.product-detial-page .product-detail-wrap .product-detail {
    padding-top: 40px;
    width: calc(100% - 360px);
    padding-right: 45px;
}

.product-detial-page .product-detail-wrap .product-detail .description-box {
    padding-bottom: 100px;
}

.head-page {
    position: relative;
    z-index: 102;
    display: flex;
    justify-content: space-between;
    align-items: center;
    margin-bottom: 20px;
}

.parent-page .head-page .page-title {
    font-size: 32px;
}

.text-green {
    color: #5dc2a7 !important;
}

.product-detial-page .product-detail-wrap .product-detail .description-box .description-video {
    position: relative;
    margin-bottom: 20px;
}

.product-detial-page .product-detail-wrap .product-detail .list-detail {
    margin-bottom: 20px;
}

.product-detial-page .product-detail-wrap .product-detail .list-detail li {
    padding-left: 24px;
    position: relative;
    font-size: 18px;
    margin-bottom: 10px;
    text-align: justify;
}

.embed-responsive {
    position: relative;
    display: block;
    width: 100%;
    padding: 0;
    overflow: hidden;
}

.product-detial-page .product-detail-wrap .product-detail .list-detail li {
    padding-left: 24px;
    position: relative;
    font-size: 18px;
    margin-bottom: 10px;
    text-align: justify;
}

.product-detial-page .product-detail-wrap .group-information {
    display: flex;
    justify-content: space-between;
    flex-flow: wrap;
}

.product-detial-page .product-detail-wrap .group-information .information-col {
    width: 45%;
}
.product-detial-page .product-detail-wrap .m-title {
    font-size: 18px;
    display: block;
    margin-bottom: 20px;
}
.product-detial-page .product-detail-wrap .product-detail .list-detail {
    margin-bottom: 20px;
}

.product-detial-page .product-detail-wrap .product-detail .list-detail li {
    padding-left: 24px;
    position: relative;
    font-size: 18px;
    margin-bottom: 10px;
    text-align: justify;
}

.product-detial-page .product-detail-wrap .product-detail .list-detail li::before {
    content: "";
    width: 5px;
    height: 5px;
    background-color: #000;
    border-radius: 50%;
    position: absolute;
    left: 10px;
    top: 10px;
}
.product-detial-page .product-detail-wrap .product-detail .armorial-box .armorial-guide {
    font-size: 18px;
    margin-bottom: 10px;
}
.product-detial-page .product-detail-wrap .product-detail .armorial-box .armorial-list {
    display: flex;
    flex-flow: wrap;
    margin-left: -8px;
    margin-right: -8px;
}

.product-detial-page .product-detail-wrap .product-detail .armorial-box .armorial-list li {
    padding: 0 8px;
    margin-bottom: 8px;
}
.slick-track {
    display: flex;
    justify-content: space-around;
    align-items: center;
    flex-wrap: wrap;
}

.product-detial-page .product-detail-wrap .sidebar-register {
    width: 360px;
    padding-right: 60px;
}
.product-detial-page .product-detail-wrap .sidebar-register .form-register {
    margin-top: -204px;
    padding: 30px 20px;
    background: #FFFFFF;
    box-shadow: 0px 2px 48px rgba(0, 0, 0, 0.08);
    border-radius: 20px;
}
.product-detial-page .product-detail-wrap .sidebar-register .form-register .course-price {
    display: flex;
    align-items: flex-start;
    justify-content: center;
    margin-bottom: 34px;
    font-size: 18px;
}

.product-detial-page .product-detail-wrap .sidebar-register .form-register .course-price .price-label {
    margin-bottom: 0;
    padding-right: 4px;
    line-height: 100%;
}
.product-detial-page .product-detail-wrap .sidebar-register .form-register .course-price .price {
    font-size: 32px;
    color: #F44336;
    line-height: 90%;
}

.product-detial-page .product-detail-wrap .sidebar-register .form-register .course-price .unit {
    padding-left: 3px;
}
.product-detial-page .product-detail-wrap .sidebar-register .form-register .course-price .unit .unit-label {
    font-size: 18px;
    text-decoration: underline;
}
.product-detial-page .product-detail-wrap .sidebar-register .form-register .btn-register {
    background-color: var(--bd-orange);
    padding: 10px;
    width: 100%;
    font-size: 18px;
    color: #fff;
}
.btn-animation span {
    position: relative;
    z-index: 5;
}
.product-detial-page .product-detail-wrap .sidebar-register .form-register .space-or {
    position: relative;
    margin: 30px 0;
    color: #979797;
    text-align: center;
}
.product-detial-page .product-detail-wrap .sidebar-register .form-register .space-or span {
    font-weight: 700;
    padding: 0 15px;
    position: relative;
    z-index: 2;
    background-color: #fff;
    font-size: 12px;
}
.product-detial-page .product-detail-wrap .sidebar-register .form-register .btn-call {
    line-height: 100%;
    border-radius: 50px;
    padding: 14px;
    border: 1px solid #5dc2a7;
    font-size: 18px;
    font-weight: 700;
    width: 100%;
    background-color: #fff;
    margin-bottom: 37px;
}
.form-group {
    margin-bottom: 1rem;
}
.product-detial-page .product-detail-wrap .sidebar-register .form-register .form-group .form-label {
    display: block;
    margin-bottom: 0;
}
.product-detial-page .product-detail-wrap .sidebar-register .form-register .form-group .form-text {
    margin-top: 0;
    font-size: 18px;
    font-weight: 700;
}
.slick-list.draggable {
    display: flex;
    width: 1440px;
}

.sidebar-register {
    position: absolute;
    z-index: 5000;
    top: 400px;
    right: 50px;
}

.product-detial-page .product-detail-wrap .sidebar-register .form-register .btn-register {
    background-color: #eb9138;
    padding: 10px;
    width: 100%;
    font-size: 18px;
    border-radius: 50px;
    color: #fff;
}

.btn-animation span {
    position: relative;
    z-index: 5;
}
.product-detial-page .product-detail-wrap .sidebar-register .form-register .btn-register strong {
    font-size: 22px;
    display: block;
    margin-bottom: 4px;

}

.product-detial-page .product-detail-wrap .sidebar-register .form-register .space-or::after {
    position: absolute;
    left: 0;
    top: 50%;
    content: "";
    width: 100%;
    height: 1px;
    background-color: #979797;
}

body {
    color: #000;
    font-weight: 500;
    font-size: 14px;
    word-break: break-word;
    word-wrap: break-word;
    white-space: normal;
    line-height: 1.4;
    position: relative;
    background-color: #F2F6FE;
    padding-top: 130px;
}

.form-group {
    font-size: 14px;
}

iframe.embed-responsive-item {
    width: 1000px;
    height: 500px;
}
</style>