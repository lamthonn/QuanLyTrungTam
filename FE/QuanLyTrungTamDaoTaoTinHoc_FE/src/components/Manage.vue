<template>
  <div style="width: 76%; margin-left:12%;">
    <a-tabs>
      <a-tab-pane key="1" tab="Học Viên">
        <a-card title="Danh sách học viên"></a-card>
        <a-table :columns="columnsHV" :data-source="danhSachHocVien"
          :pagination="{ pageSize: pageSize, current: curentPage, total: totalCount }" @change="handlePageChange" bordered>
          <template #bodyCell="{ column, record }">
            <template v-if="column.dataIndex === 'action'">
              <a-button Danger @click="showPopupSuaThongTinHocVien(record)"><i class="fa-solid fa-pen"></i></a-button>
              <a-button Danger @click="XoaThongTinHocVien(record)" style="margin-left: 5px;"><i
                  class="fa-solid fa-trash"></i></a-button>
            </template>
          </template>
        </a-table>
      </a-tab-pane>

      <a-tab-pane key="2" tab="Giảng Viên">
        <a-card title="Danh sách học viên"></a-card>
        <a-table :columns="columnsGV" :data-source="danhSachGiangVien"
          :pagination="{ pageSize: pageSize2, current: curentPage2, total: totalCount2 }" @change="handlePageChangeGV" bordered>
          <template #bodyCell="{ column, record }">
            <template v-if="column.dataIndex === 'action'">
              <a-button Danger @click="showPopupSuaThongTinGiangVien(record)"><i class="fa-solid fa-pen"></i></a-button>
              <a-button Danger @click="XoaThongTinGiangVien(record)" style="margin-left: 5px;"><i
                  class="fa-solid fa-trash"></i></a-button>
            </template>
          </template>
        </a-table>
      </a-tab-pane>
    </a-tabs>
  </div>
  <SuaHocVienVue ref="xemRef"></SuaHocVienVue>
  <SuaGiangVienVue ref="xemGVRef"></SuaGiangVienVue>
</template>

<script>
import { Tabs, TabPane, Collapse, notification, Table, Card, Button } from 'ant-design-vue/es/components'
import axios from 'axios';
import { ref, onMounted } from 'vue';  // Import ref và onMounted từ Vue
import SuaHocVienVue from './ManageComponent/SuaHocVien.vue';
import SuaGiangVienVue from './ManageComponent/SuaGiangVien.vue';

export default {
  name: 'manage',
  components: {
    ATabs: Tabs,
    ATabPane: TabPane,
    ACollapse: Collapse,
    ATable: Table,
    ACard: Card,
    AButton: Button,
    SuaHocVienVue,SuaGiangVienVue
  },
  setup() {
    const danhSachHocVien = ref([]);
    const danhSachGiangVien = ref([]);
    const pageSize = ref(5)
    const curentPage = ref(1)
    const totalCount = ref(0);
    const pageSize2 = ref(5)
    const curentPage2 = ref(1)
    const totalCount2 = ref(0);

    const xemRef = ref();
    const xemGVRef = ref();
    
    const HVGetData = () => {
      axios.get(`https://localhost:7255/api/HocVien?currentPage=${curentPage.value}&PAGE_SIZE=${pageSize.value}`)
        .then(res => {
          danhSachHocVien.value = res.data.hocViens;  // Sử dụng .value để gán giá trị cho ref
          totalCount.value = res.data.totalCount;  // Sử dụng .value để gán giá trị cho ref
          console.log(res.data);  // Sử dụng .value để gán giá trị cho ref
        })
        .catch(err => {
          notification.open({
            message: `lỗi khi lấy dữ liệu học viên:${err}`,
            onClick: () => {
              console.log('Notification Clicked!');
            },
          });
        });
    }
    const GVGetData = () => {
      axios.get("https://localhost:7255/api/GiangVien/getAllGV")
        .then(res => {
          totalCount2.value = res.data.totalCount;
          danhSachGiangVien.value = res.data.giangViens;  // Sử dụng .value để gán giá trị cho ref
        })
        .catch(err => {
          notification.open({
            message: `lỗi khi lấy dữ liệu giảng viên:${err}`,
            onClick: () => {
              console.log('Notification Clicked!');
            },
          });
        });
    }
    onMounted(async () => {
      await HVGetData();
      await GVGetData();
    });

    const columnsHV = [
      {
        title: 'Mã học viên',
        dataIndex: 'maHV',
      },
      {
        title: 'Tên học viên',
        dataIndex: 'tenHV',
      },
      {
        title: 'Địa chỉ',
        dataIndex: 'diaChi',
      },
      {
        title: 'Số điện thoại',
        dataIndex: 'sdt',
      },
      {
        title: 'Email',
        dataIndex: 'email',
      },
      {
        title: 'Ngày sinh',
        dataIndex: 'ngaySinh',
      },
      {
        title: 'Giới tính',
        dataIndex: 'gioiTinh',
      },
      {
        title: 'Thao tác',
        dataIndex: 'action',
      },
    ]
    const columnsGV = [
      {
        title: 'Mã giảng viên',
        dataIndex: 'maGV',
      },
      {
        title: 'Tên giảng viên',
        dataIndex: 'tenGV',
      },
      {
        title: 'Địa chỉ',
        dataIndex: 'diaChi',
      },
      {
        title: 'Số điện thoại',
        dataIndex: 'sdt',
      },
      {
        title: 'Email',
        dataIndex: 'email',
      },
      {
        title: 'Ngày sinh',
        dataIndex: 'ngaySinh',
      },
      {
        title: 'Giới tính',
        dataIndex: 'gioiTinh',
      },
      {
        title: 'Thao tác',
        dataIndex: 'action',
      },
    ]

    const showPopupSuaThongTinHocVien = (record) => {
      xemRef.value.visible = true
      xemRef.value.record = record
    }
    const showPopupSuaThongTinGiangVien = (record) => {
      xemGVRef.value.visible = true
      xemGVRef.value.record = record
    }

    const XoaThongTinGiangVien = async (record) => {
      if (confirm("bạn chắc chắn muốn xóa thông tin này?")) {
        await axios.delete(`https://localhost:7255/api/GiangVien/DeleteDataGV?magv=${record.maGV}`)
          .then(() => {
            notification.open({
              message: 'Thông báo',
              description:'Xóa thông tin thành công',
              onClick: () => {
                console.log('Notification Clicked!');
              },
            });
          })
          GVGetData()
      }
    }


    const XoaThongTinHocVien = async (record) => {
      if (confirm("bạn chắc chắn muốn xóa thông tin này?")) {
        await axios.delete(`https://localhost:7255/api/HocVien/delete?mavh=${record.maHV}`)
          .then(() => {
            notification.open({
              message: 'Thông báo',
              description:'Xóa thông tin thành công',
              onClick: () => {
                console.log('Notification Clicked!');
              },
            });
          })
        HVGetData()
      }
    }



    const handlePageChange = (pagination) => {
      curentPage.value = pagination.current;
      HVGetData();
    }
    const handlePageChangeGV = (pagination) => {
      curentPage2.value = pagination.current;
      GVGetData();
    }
    return {
      danhSachHocVien,
      danhSachGiangVien,
      columnsHV,
      pageSize,
      curentPage,
      totalCount,
      pageSize2,
      curentPage2,
      totalCount2,
      xemRef,
      columnsGV,
      xemGVRef,

      handlePageChange,
      HVGetData,
      GVGetData,
      showPopupSuaThongTinHocVien,
      XoaThongTinHocVien,
      handlePageChangeGV,
      showPopupSuaThongTinGiangVien,
      XoaThongTinGiangVien
    }
  },
};
</script>


<style scoped>
body {
  font-weight: 300;
  line-height: 1.42em;
  color: #000;
  background-color: #a3d6ca;
}

h1 {
  font-size: 3em;
  font-weight: 300;
  line-height: 1em;
  text-align: center;
  color: #4DC3FA;
}

h2 {
  text-align: center;
  padding-top: 10px;
  font-weight: bold;
  color: #198754;
}

.blue {
  color: #185875;
}

.yellow {
  color: #FFF842;
}

.container th h1 {
  font-weight: bold;
  font-size: 1em;
  text-align: left;
  color: #185875;
}

.container td {
  font-weight: normal;
  font-size: 1em;
  -webkit-box-shadow: 0 2px 2px -2px #0E1119;
  -moz-box-shadow: 0 2px 2px -2px #0E1119;
  box-shadow: 0 2px 2px -2px #0E1119;
}

.container {
  text-align: left;
  overflow: hidden;
  width: 80%;
  margin: 0 auto;
  display: table;
}

.container td,
.container th {
  padding-bottom: 2%;
  padding-top: 2%;
  padding-left: 2%;
}

/* Background-color of the odd rows */
.container tr:nth-child(odd) {
  background-color: #fff;
}

/* Background-color of the even rows */
.container tr:nth-child(even) {
  background-color: #fff;
}

.container th {
  background-color: #88cfae;
}

.container tr:hover {
  /* //background-color: #464A52; */
  -webkit-box-shadow: 0 6px 6px -6px #0E1119;
  -moz-box-shadow: 0 6px 6px -6px #0E1119;
  box-shadow: 0 6px 6px -6px #0E1119;
}

.container td:hover {
  font-weight: bold;
}

@media (max-width: 800px) {

  .container td:nth-child(4),
  .container th:nth-child(4) {
    display: none;
  }
}

th,
td {
  border: 1px solid #185338;
  text-align: left;
  padding: 8px;
}

.ant-tabs-tab.ant-tabs-tab-active {
  font-size: 25px !important;
  font-weight: bold !important;
}

.ant-tabs-nav-wrap {
  justify-content: center;
}

div#rc-tabs-2-tab-1 {
  color: #198754;
}

.frame {
  width: 90%;
  text-align: center;
  display: flex;
}

.frame .iconOperation {
  width: 30px;
}

.frame .iconOperation:hover {
  color: #185338;
  cursor: pointer;
  font-weight: bold;
}</style>