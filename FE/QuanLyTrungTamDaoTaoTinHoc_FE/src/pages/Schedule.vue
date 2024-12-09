<template>
  <a-calendar v-model:value="value">
    <template #dateCellRender="{ current }">
      <ul class="events">
        <li v-for="item in getListData(current)" :key="item.content">
          <a-badge :status="item.type" :text="item.content" />
        </li>
      </ul>
    </template>
    <template #monthCellRender="{ current }">
      <div v-if="getMonthData(current)" class="notes-month">
        <section>{{ getMonthData(current) }}</section>
        <span>Backlog number</span>
      </div>
    </template>
  </a-calendar>
</template>

<script>
import { computed, ref } from "vue";
import { Dayjs } from "dayjs";
import { Calendar, Badge } from "ant-design-vue/es/components";
import apiUrl from "@/store/api";
import axios from "axios";

export default {
  components: {
    ACalendar: Calendar,
    ABadge: Badge,
  },
  setup() {
    const value = ref();
    const dataCousre = ref([]);
    const username = computed(() => localStorage.getItem("USERNAME"));
    const getListData = (value) => {
      let listData;
      switch (value.date()) {
        case 3:
          dataCousre.value.forEach((item) => {
            if (item.khoaHocId === "KH3") {
              listData = [
                { type: "warning", content: "Thiết kế hoạt hình 3D" },
                { type: "success", content: "Phòng học:A101" },
                { type: "error", content: "Giảng viên: Minh Tuấn" },
              ];
            }
          });
          break;
        case 10:
          dataCousre.value.forEach((item) => {
            if (item.khoaHocId === "KH3") {
              listData = [
                { type: "warning", content: "Thiết kế hoạt hình 3D" },
                { type: "success", content: "Phòng học:A101" },
                { type: "error", content: "Giảng viên: Minh Tuấn" },
              ];
            }
          });
          break;
        case 17:
          dataCousre.value.forEach((item) => {
            if (item.khoaHocId === "KH3") {
              listData = [
                { type: "warning", content: "Thiết kế hoạt hình 3D" },
                { type: "success", content: "Phòng học:A101" },
                { type: "error", content: "Giảng viên: Minh Tuấn" },
              ];
            }
          });
          break;
        case 24:
          dataCousre.value.forEach((item) => {
            if (item.khoaHocId === "KH3") {
              listData = [
                { type: "warning", content: "Thiết kế hoạt hình 3D" },
                { type: "success", content: "Phòng học:A101" },
                { type: "error", content: "Giảng viên: Minh Tuấn" },
              ];
            }
          });
          break;
        case 31:
          dataCousre.value.forEach((item) => {
            if (item.khoaHocId === "KH3") {
              listData = [
                { type: "warning", content: "Thiết kế hoạt hình 3D" },
                { type: "success", content: "Phòng học:A101" },
                { type: "error", content: "Giảng viên: Minh Tuấn" },
              ];
            }
          });
          break;
        case 6:
          dataCousre.value.forEach((item) => {
            if (item.khoaHocId === "KH1") {
              listData = [
                { type: "warning", content: "Lập trình app với Swift" },
                { type: "success", content: "Phòng học:A102" },
                { type: "error", content: "Giảng viên: Loan Đặng" },
              ];
            }
          });
          break;
        case 13:
          dataCousre.value.forEach((item) => {
            if (item.khoaHocId === "KH1") {
              listData = [
                { type: "warning", content: "Lập trình app với Swift" },
                { type: "success", content: "Phòng học:A102" },
                { type: "error", content: "Giảng viên: Loan Đặng" },
              ];
            }
          });
          break;
        case 20:
          dataCousre.value.forEach((item) => {
            if (item.khoaHocId === "KH1") {
              listData = [
                { type: "warning", content: "Lập trình app với Swift" },
                { type: "success", content: "Phòng học:A102" },
                { type: "error", content: "Giảng viên: Loan Đặng" },
              ];
            }
          });
          break;
        case 27:
          dataCousre.value.forEach((item) => {
            if (item.khoaHocId === "KH1") {
              listData = [
                { type: "warning", content: "Lập trình app với Swift" },
                { type: "success", content: "Phòng học:A102" },
                { type: "error", content: "Giảng viên: Loan Đặng" },
              ];
            }
          });
          break;

        case 5:
          dataCousre.value.forEach((item) => {
            if (item.khoaHocId === "KH2") {
              listData = [
                { type: "warning", content: "Lập trình python" },
                { type: "success", content: "Phòng học:A301" },
                { type: "error", content: "Giảng viên:Vũ Công Minh" },
              ];
            }
          });
          break;
        case 12:
          dataCousre.value.forEach((item) => {
            if (item.khoaHocId === "KH2") {
              listData = [
                { type: "warning", content: "Lập trình python" },
                { type: "success", content: "Phòng học:A301" },
                { type: "error", content: "Giảng viên:Vũ Công Minh" },
              ];
            }
          });
          break;
        case 19:
          dataCousre.value.forEach((item) => {
            if (item.khoaHocId === "KH2") {
              listData = [
                { type: "warning", content: "Lập trình python" },
                { type: "success", content: "Phòng học:A301" },
                { type: "error", content: "Giảng viên:Vũ Công Minh" },
              ];
            }
          });
          break;
        case 26:
          dataCousre.value.forEach((item) => {
            if (item.khoaHocId === "KH2") {
              listData = [
                { type: "warning", content: "Lập trình python" },
                { type: "success", content: "Phòng học:A301" },
                { type: "error", content: "Giảng viên:Vũ Công Minh" },
              ];
            }
          });
          break;
        default:
      }
      return listData || [];
    };

    const getMonthData = (value) => {
      if (value.month() === 8) {
        return 1394;
      }
    };

    const getDataCousre = () => {
      axios
        .get(`${apiUrl.CHECK_PAYMENT}?username=${username.value}`)
        .then((res) => {
          dataCousre.value = res.data;
        })
        .catch((err) => {
          console.log(err);
        });
    };

    return {
      username,
      dataCousre,
      value,
      getListData,
      getMonthData,
      getDataCousre,
    };
  },
  mounted() {
    this.getDataCousre();
  },
};
</script>

<style scoped></style>