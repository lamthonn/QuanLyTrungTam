<template>
  <ASpin :spinning="loading">
    <div id="courses">
      <div class="wrap-main">
        <div id="sidebar">
          <div class="sidebar-main">
            <div class="siderbar-head">
              <h3 class="sidebar-title">
                <span class="text-yeallow">#</span
                ><span class="font-weight-medium">Sản phẩm</span> theo môn
              </h3>
            </div>
            <ul class="sidebar-subject" id="select-subject">
              <li>
                <span class="icon"
                  ><img src="../assets/Courses/community-icon-2.svg" alt=""
                /></span>
                <div class="text">
                  <a id="get-all-courses">Tất cả</a>
                </div>
              </li>
              <li>
                <span class="icon"
                  ><img src="../assets/Courses/community-icon-2.svg" alt=""
                /></span>
                <div class="text">
                  <a id="subject-2">3D Art &amp; Multimedia</a>
                </div>
              </li>

              <li>
                <span class="icon"
                  ><img src="../assets/Courses/community-icon-2.svg" alt=""
                /></span>
                <div class="text">
                  <a id="subject-3">Programming &amp; Application</a>
                  <ul class="subject-sub" id="subject-sub-3">
                    <li value="1"><a>Programming &amp; Application</a></li>
                  </ul>
                </div>
              </li>

              <li>
                <span class="icon"
                  ><img src="../assets/Courses/community-icon-2.svg" alt=""
                /></span>
                <div class="text">
                  <a id="subject-4">Robotics &amp; Engineering</a>
                  <ul class="subject-sub" id="subject-sub-4">
                    <li value="2"><a>Robotics &amp; Engineering</a></li>
                  </ul>
                </div>
              </li>

              <li>
                <span class="icon"
                  ><img src="../assets/Courses/community-icon-2.svg" alt=""
                /></span>
                <div class="text">
                  <a id="subject-5">Trại hè công nghệ</a>
                  <ul class="subject-sub" id="subject-sub-5">
                    <li value="6"><a>Course Camp</a></li>
                  </ul>
                </div>
              </li>
            </ul>
            <div class="dot-line"></div>
            <div class="siderbar-head">
              <h3 class="sidebar-title">
                <span class="text-yeallow">#</span
                ><span class="font-weight-medium">Sản phẩm</span> theo tuổi
              </h3>
            </div>
            <ul class="sidebar-checkbox" id="checkbox-age">
              <li>
                <div class="checkbox">
                  <input
                    type="checkbox"
                    name=""
                    id="check-yearold-1"
                    value="5-7"
                  />
                  <label class="checkbox-label" for="check-yearold-1" title="5-7"
                    >5-7</label
                  >
                </div>
              </li>
              <li>
                <div class="checkbox">
                  <input
                    type="checkbox"
                    name=""
                    id="check-yearold-2"
                    value="7-11"
                  />
                  <label class="checkbox-label" for="check-yearold-2" title="7-11"
                    >7-11</label
                  >
                </div>
              </li>
              <li>
                <div class="checkbox">
                  <input
                    type="checkbox"
                    name=""
                    id="check-yearold-3"
                    value="11-15"
                  />
                  <label
                    class="checkbox-label"
                    for="check-yearold-3"
                    title="11-15"
                    >11-15</label
                  >
                </div>
              </li>
              <li>
                <div class="checkbox">
                  <input
                    type="checkbox"
                    name=""
                    id="check-yearold-4"
                    value="11-18"
                  />
                  <label
                    class="checkbox-label"
                    for="check-yearold-4"
                    title="11-18"
                    >11-18</label
                  >
                </div>
              </li>
              <li>
                <div class="checkbox">
                  <input
                    type="checkbox"
                    name=""
                    id="check-yearold-5"
                    value="12"
                  />
                  <label class="checkbox-label" for="check-yearold-5" title="12"
                    >12</label
                  >
                </div>
              </li>
            </ul>
            <div class="dot-line"></div>
            <div class="siderbar-head">
              <h3 class="sidebar-title">
                <span class="text-yeallow">#</span
                ><span class="font-weight-medium">Sản phẩm</span> theo loại
              </h3>
            </div>
          </div>
        </div>
        <div class="main main-full">
          <div
            v-if="role === '1' || roleData === '1'"
            style="display: flex; justify-content: flex-end"
          >
            <a-dropdown-button @click="handleButtonClick">
              Khác
              <template #overlay>
                <a-menu @click="handleMenuClick">
                  <a-menu-item @click="showModal" key="1"
                    >Thêm khóa học</a-menu-item
                  >
                </a-menu>
              </template>
            </a-dropdown-button>
          </div>
          <div class="head-page">
            <h2 class="page-title">
              <span class="text-green" v-if="Courses3DArt.length > 0">#</span>3D
              Art &amp; Multimedia
            </h2>
            <router-link to="/detailCourse"></router-link>
            <div class="head-views">
              <p
                class="result-search"
                id="result-search-2"
                style="scroll-margin-top: 150px"
              >
                Có tổng cộng
                <u class="font-weight-bold">{{ Courses3DArt.length }} Khóa học</u>
                được tìm thấy
              </p>
            </div>
          </div>
          <ul class="course-list" id="course-list-2">
            <li v-for="course in Courses3DArt" :key="course.maKH">
              <div class="course-thumb">
                <router-link
                  :to="{ name: 'detailCourse', params: { maKH: course.maKH } }"
                  ><img :src="require(`../assets/Courses/${course.pathImage}`)"
                /></router-link>
              </div>
              <div class="course-info">
                <router-link
                  :to="{ name: 'detailCourse', params: { maKH: course.maKH } }"
                  ><h3 class="course-name">
                    <a href="">{{ course.tenKH }}</a>
                  </h3></router-link
                >
                <div class="course-row">
                  <div class="course-price">
                    <label class="price-label">Chỉ còn</label>
                    <div class="price">
                      <strong>{{ course.price }}</strong
                      >.000
                    </div>
                    <div class="unit"><sup class="unit-label">đ</sup>/giờ</div>
                  </div>
                  <div class="course-prize">
                    <span class="prize-poin">{{ course.rate }}</span>
                    <div class="prize-star">
                      <img
                        class="svg"
                        src="../assets/Courses/3D_ART/start-icon.svg"
                      />
                      <img
                        class="svg"
                        src="../assets/Courses/3D_ART/start-icon.svg"
                      />
                      <img
                        class="svg"
                        src="../assets/Courses/3D_ART/start-icon.svg"
                      />
                      <img
                        class="svg"
                        src="../assets/Courses/3D_ART/start-icon.svg"
                      />
                      <img
                        class="svg"
                        src="../assets/Courses/3D_ART/start-half-icon.svg"
                      />
                    </div>
                    <span class="prize-total">(2543)</span>
                  </div>
                  <span class="course-ctg">{{ course.luaTuoi }} tuổi</span>
                </div>
                <p class="course-text">{{ course.description }}</p>
                <div class="course-tools">
                  <!-- <span><img src="projects/tools/2022/03/01/CoSpaces_Logo.svg.png" alt=""></span>
                                  <span><img src="projects/tools/2022/04/29/Robot_Thumbnail_Resized-e1574666381369.png" alt=""></span>
                                  <span><img src="projects/tools/2022/03/01/xyz-print.png" alt=""></span> -->
                </div>
              </div>
              <div class="control" v-if="role === '1' || roleData === '1'">
                <div class="frame">
                  <i
                    class="custom-btn btn-10 iconedit"
                    @click="showModalEdit(course)"
                    >Sửa</i
                  >
                  <i
                    class="custom-btn btn-10 icondelete"
                    @click="deleteKhoaHoc(course)"
                    >Xóa</i
                  >
                </div>
              </div>
            </li>
          </ul>

          <div class="head-page">
            <h2 class="page-title">
              <span class="text-green" v-if="CoursesApp.length > 0">#</span
              >Programming &amp; Application
            </h2>
            <div class="head-views">
              <p
                class="result-search"
                id="result-search-2"
                style="scroll-margin-top: 150px"
              >
                Có tổng cộng
                <u class="font-weight-bold">{{ CoursesApp.length }} Khóa học</u>
                được tìm thấy
              </p>
            </div>
          </div>
          <ul class="course-list" id="course-list-2">
            <li v-for="course in CoursesApp" :key="course.maKH">
              <div class="course-thumb">
                <router-link
                  :to="{ name: 'detailCourse', params: { maKH: course.maKH } }"
                  ><img :src="require(`../assets/Courses/${course.pathImage}`)"
                /></router-link>
              </div>
              <div class="course-info">
                <router-link
                  :to="{ name: 'detailCourse', params: { maKH: course.maKH } }"
                  ><h3 class="course-name">
                    <a href="">{{ course.tenKH }}</a>
                  </h3></router-link
                >
                <div class="course-row">
                  <div class="course-price">
                    <label class="price-label">Chỉ còn</label>
                    <div class="price">
                      <strong>{{ course.price }}</strong
                      >.000
                    </div>
                    <div class="unit"><sup class="unit-label">đ</sup>/giờ</div>
                  </div>
                  <div class="course-prize">
                    <span class="prize-poin">{{ course.rate }}</span>
                    <div class="prize-star">
                      <img
                        class="svg"
                        src="../assets/Courses/3D_ART/start-icon.svg"
                      />
                      <img
                        class="svg"
                        src="../assets/Courses/3D_ART/start-icon.svg"
                      />
                      <img
                        class="svg"
                        src="../assets/Courses/3D_ART/start-icon.svg"
                      />
                      <img
                        class="svg"
                        src="../assets/Courses/3D_ART/start-icon.svg"
                      />
                      <img
                        class="svg"
                        src="../assets/Courses/3D_ART/start-half-icon.svg"
                      />
                    </div>
                    <span class="prize-total">(2543)</span>
                  </div>
                  <span class="course-ctg">{{ course.luaTuoi }} tuổi</span>
                </div>
                <p class="course-text">{{ course.description }}</p>
                <div class="course-tools">
                  <!-- <span><img src="projects/tools/2022/03/01/CoSpaces_Logo.svg.png" alt=""></span>
                                  <span><img src="projects/tools/2022/04/29/Robot_Thumbnail_Resized-e1574666381369.png" alt=""></span>
                                  <span><img src="projects/tools/2022/03/01/xyz-print.png" alt=""></span> -->
                </div>
              </div>
              <div class="control" v-if="role === '1' || roleData === '1'">
                <div class="frame">
                  <i
                    class="custom-btn btn-10 iconedit"
                    @click="showModalEdit(course)"
                    >Sửa</i
                  >
                  <i
                    class="custom-btn btn-10 icondelete"
                    @click="deleteKhoaHoc(course)"
                    >Xóa</i
                  >
                </div>
              </div>
            </li>
          </ul>
        </div>
      </div>
    </div>
</ASpin>
  <AddNewCourse ref="xemRef" />
  <UpdateCourse ref="xemRefUpdate"></UpdateCourse>
</template>
<script>
import {
  Carousel,
  DropdownButton,
  Menu,
  MenuItem,
  Spin
} from "ant-design-vue/es/components";
import { computed, ref } from "vue";
import axios from "axios";
import { useStore } from "vuex";
import { EllipsisOutlined, DownOutlined } from "@ant-design/icons-vue";
import AddNewCourse from "@/components/course/AddNewCourse.vue";
import UpdateCourse from "@/components/course/UpdateCourse.vue";
import apiUrl from "@/store/api";
export default {
  name: "Courses-",
  components: {
    ACarousel: Carousel,
    AddNewCourse,
    ADropdownButton: DropdownButton,
    AMenuItem: MenuItem,
    AMenu: Menu,
    UpdateCourse,
    ASpin: Spin,
    EllipsisOutlined,
    DownOutlined,
  },
  setup() {
    const store = useStore();
    const loading = ref(false)
    //data người dùng
    const role = ref(localStorage.getItem("ROLE"));
    const roleData = computed(() => store.state.Role);

    //data các khóa học
    const CoursesApp = ref([]);
    const Courses3DArt = ref([]);

    const xemRef = ref();
    const xemRefUpdate = ref();

    const getData = async (tenLoai) => {
      loading.value = true;
      const respone = await axios.post(apiUrl.GET_ALL_KHOA_HOC, {
        loai: tenLoai,
      });
      loading.value = false;
      return respone.data;
    };
    //get data khóa học Programming & Application
    const getCoursesApp = async () => {
      CoursesApp.value = await getData("Programming&Application");
      console.log(CoursesApp.value);
    };

    //get data khóa học 3D Art & Multimedia
    const getCourses3DArt = async () => {
      Courses3DArt.value = await getData("3D_ART");
    };

    const showModal = () => {
      xemRef.value.visible = true;
    };
    const handleButtonClick = (e) => {
      console.log("click left button", e);
    };
    const handleMenuClick = (e) => {
      console.log("click", e);
    };
    const showModalEdit = (course) => {
      xemRefUpdate.value.visible = true;
      xemRefUpdate.value.record = course;
    };

    const deleteKhoaHoc = (course) => {
      if (confirm("bạn muốn xóa khóa học này?")) {
        axios
          .delete(`${apiUrl.DELETE_KHOA_HOC}/${course}`)
          .then(() => {
            notification.open({
              message: "Thông báo",
              description: "Xóa khóa học thành công",
              onClick: () => {
                console.log("Notification Clicked!");
              },
            });
          })
          .catch((err) => {
            notification.open({
              message: "Thông báo",
              description: "Xóa khóa học không thành công",
              onClick: () => {
                console.log("Notification Clicked!");
              },
            });
          });
      }
    };

    return {
      store,
      CoursesApp,
      Courses3DArt,
      role,
      roleData,
      xemRef,
      xemRefUpdate,loading,

      getCoursesApp,
      getCourses3DArt,
      showModal,
      handleButtonClick,
      handleMenuClick,
      showModalEdit,
      deleteKhoaHoc,
    };
  },
  mounted() {
    
    this.getCoursesApp();
    this.getCourses3DArt();
  },
};
</script>

<style scoped>
.demo-dropdown-wrap :deep(.ant-dropdown-button) {
  margin-right: 8px;
  margin-bottom: 8px;
}
* {
  font-family: "Quicksand", sans-serif;
}
#courses {
  height: 1500px;
}
.custom-btn {
  width: 130px;
  height: 40px;
  color: #5dc2a7;
  border-radius: 5px;
  padding: 10px 25px;
  font-weight: 500;
  background: transparent;
  cursor: pointer;
  transition: all 0.3s ease;
  position: relative;
  display: inline-block;
  box-shadow: inset 2px 2px 2px 0px rgba(255, 255, 255, 0.5),
    7px 7px 20px 0px rgba(0, 0, 0, 0.1), 4px 4px 5px 0px rgba(0, 0, 0, 0.1);
  outline: none;
}
.frame {
  width: 90%;
  margin: 40px auto;
  text-align: center;
  display: block;
}
/* start: wrap-main */
.wrap-main {
  display: flex;
}
.wrap-main #sidebar {
  min-width: 250px;
  width: 250px;
  border-right: 1px solid #e7e8ea;
}
.wrap-main #sidebar .sidebar-main {
  background-color: #fff;
  padding-right: 5px;
}
.wrap-main #sidebar .siderbar-head {
  margin-bottom: 20px;
}
.wrap-main #sidebar .sidebar-main {
  background-color: #f2f6fe;
  /* position: sticky; */
  top: 130px;
  height: calc(100vh - 130px);
  padding: 20px 17px 32px;
  perspective: 1px;
  scrollbar-color: rgba(0, 0, 0, 0.1) transparent;
  scrollbar-width: 4px;
}
.wrap-main #sidebar .sidebar-title {
  font-size: 18px;
  margin-bottom: 0;
}
.text-yeallow {
  color: #ffa800 !important;
}
ul#select-subject {
  padding-left: 0;
}
.wrap-main #sidebar .sidebar-subject > li {
  margin-bottom: 8px;
  display: flex;
}
.wrap-main #sidebar .sidebar-subject > li .icon {
  width: 32px;
  height: 32px;
  border-radius: 50%;
  display: flex;
  align-items: center;
  justify-content: center;
}
.wrap-main #sidebar .sidebar-subject > li .text {
  flex: 1;
  padding: 7px 10px;
}
.wrap-main #sidebar .sidebar-subject > li .text > a {
  display: block;
}

.checkbox input {
  margin-right: 20px;
}

/*start: main-full */
.wrap-main .main {
  padding-left: 40px;
}
.wrap-main .main {
  flex: 1;
  padding: 20px 20px 50px 30px;
}
.head-page {
  position: relative;
  z-index: 102;
  display: flex;
  justify-content: space-between;
  align-items: center;
  margin-bottom: 20px;
}
.head-page .page-title {
  font-size: 32px;
  font-weight: 700;
  margin-bottom: 0;
}
.wrap-main .main .head-page .head-views {
  display: flex;
  align-items: center;
  justify-content: flex-end;
}
.text-green {
  color: #5dc2a7 !important;
}
.wrap-main .main .head-page .head-views .result-search {
  margin-bottom: 0;
  padding-top: 10px;
}
.font-weight-bold {
  font-weight: 700 !important;
}

.course-list {
  margin-bottom: 165px;
}
.course-list li {
  background: #ffffff;
  box-shadow: 0px 2px 48px rgba(0, 0, 0, 0.08);
  border-radius: 20px;
  padding: 20px;
  display: flex;
  justify-content: space-between;
  margin-bottom: 30px;
}
.course-list li .course-thumb {
  width: 160px;
  height: 160px;
  border-radius: 20px;
  background-color: #d9d9d9;
}
.course-list li .course-thumb img {
  width: 100%;
  height: 100%;
  object-fit: cover;
}

.course-list li .course-info {
  width: calc(100% - 160px);
  padding-left: 30px;
}

.course-list li .course-info .course-name {
  font-size: 22px;
  font-weight: 700;
  margin-bottom: 10px;
  line-height: 100%;
}

.course-list li .course-info .course-row {
  display: flex;
  align-items: center;
  flex-flow: wrap;
  margin-bottom: 6px;
}

.course-list li .course-info .course-row .course-price {
  display: flex;
  align-items: center;
  border-right: 1px dashed #000000;
  padding-right: 27px;
  margin-right: 18px;
}

.course-list li .course-info .course-row .course-price .price-label {
  font-weight: 700;
  margin-bottom: 8px;
  padding-right: 4px;
}

.course-list li .course-info .course-row .course-price .price {
  font-size: 22px;
  color: #f44336;
  line-height: 90%;
}

.course-list li .course-info .course-row .course-price .unit {
  padding-left: 3px;
}

.course-list li .course-info .course-row .course-price .unit .unit-label {
  font-size: 14px;
  text-decoration: underline;
}

sup {
  top: -0.5em;
}

.course-list li .course-info .course-row .course-prize {
  display: flex;
  align-items: center;
  font-weight: 700;
  margin-right: 50px;
}

.course-list li .course-info .course-row .course-prize .prize-poin {
  color: #be5a0e;
}

.course-list li .course-info .course-row .course-prize .prize-star {
  display: flex;
  padding: 0 8px 0 4px;
}

.svg {
  transition: all ease 0.3s;
  vertical-align: middle;
}

.course-list li .course-info .course-row .course-prize .prize-total {
  color: #767676;
}
.course-list li .course-info .course-row .course-ctg {
  padding: 4px 12px;
  border-radius: 30px;
  background: #ffe799;
  font-weight: 700;
}

.course-list li .course-info .course-text {
  margin-bottom: 10px;
  font-size: 18px;
  font-weight: 400;
  overflow: hidden;
}

.course-list li .course-info .course-tools {
  display: flex;
  align-items: center;
  flex-flow: wrap;
}
.btn-10 {
  background: #5dc2a7;
  background: linear-gradient(0deg, #5dc2a7 0%, #5dc2a7 100%);
  color: #fff;
  border: none;
  transition: all 0.3s ease;
  overflow: hidden;
  width: 135px;
}
.btn-10:after {
  position: absolute;
  content: " ";
  top: 0;
  left: 0;
  z-index: -1;
  width: 100%;
  height: 100%;
  transition: all 0.3s ease;
  -webkit-transform: scale(0.1);
  transform: scale(0.1);
}
.btn-10:hover {
  color: #fff;
  border: none;
  background: transparent;
  background-color: #40796a;
}
.btn-10:hover:after {
  background: rgb(0, 3, 255);
  background: linear-gradient(
    0deg,
    rgba(2, 126, 251, 1) 0%,
    rgba(0, 3, 255, 1) 100%
  );
  -webkit-transform: scale(1);
  transform: scale(1);
}
.control {
  width: 150px;
}
.modal.open {
  display: flex;
}

.modal .modal-close {
  display: block;
}

.madal-container {
  background-color: #fff;
  width: 900px;
  max-width: calc(100% - 32px);
  min-height: 200px;
  position: relative;
  animation: modalFadeIn ease 0.5s;
  margin-left: 300px;
  margin-top: 50px;
}

header {
  background-color: #009688;
  height: 130px;
  display: flex;
  align-items: center;
  justify-content: center;
  font-size: 30px;
  color: #fff;
}

header .ti-bag {
  padding-right: 16px;
}

.modal-close:hover {
  opacity: 1;
}

.modal-close {
  position: absolute;
  right: 0;
  top: 0;
  color: #fff;
  padding: 12px;
  cursor: pointer;
  opacity: 0.8;
}

/* tạo chuyển động cho modal */
@keyframes modalFadeIn {
  from {
    /* cho từ mờ */
    opacity: 0;
    transform: translateY(-140px);
  }
  to {
    /* đển rõ */
    opacity: 1;
    /* trả về vị trí ban đầu */
    transform: translateY(0);
  }
}
.modal {
  position: fixed;
  top: 0;
  left: 0;
  z-index: 5;
  display: none;
  width: 100%;
  height: 100%;
  overflow-x: hidden;
  overflow-y: auto;
  outline: 0;
}
/*end: main-full */
/* end: wrap-main */
</style>