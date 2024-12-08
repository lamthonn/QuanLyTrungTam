<template>
    <a-modal v-model:open="visible" width="40%" title="Sửa thông tin giảng viên" :centered="true" @ok="SuaGiangVien"
        class="addNewCourse">
        <div>
            <a-form-item>
                <a-input addonBefore="Mã giảng viên" v-model:value="formState.maGV" disabled placeholder="Mã học viên" allow-clear />
            </a-form-item>
            <a-form-item>
                <a-input addonBefore="Tên giảng viên" v-model:value="formState.tenGV" placeholder="Tên học viên" allow-clear />
            </a-form-item>
            <a-form-item>
                <a-input addonBefore="Email" v-model:value="formState.email" placeholder="Email" allow-clear />
            </a-form-item>
            <a-form-item>
                <a-input addonBefore="Ngày sinh" v-model:value="formState.ngaySinh" placeholder="Ngày sinh" allow-clear />
            </a-form-item>
            <a-form-item>
                <a-input addonBefore="Địa chỉ" v-model:value="formState.diaChi" placeholder="Địa chỉ" allow-clear />
            </a-form-item>
            <a-form-item>
                <a-input addonBefore="Số điện thoại" v-model:value="formState.sdt" placeholder="Số điện thoại" allow-clear />
            </a-form-item>
            <a-form-item>
                <a-input addonBefore="Giới tính" v-model:value="formState.gioiTinh" placeholder="Giới tính" allow-clear />
            </a-form-item>
        </div>

    </a-modal>
</template>
  
<script>
import { reactive, ref, watch } from 'vue';
import { Modal, FormItem, Input, DatePicker, notification  } from 'ant-design-vue';
import axios from 'axios';
export default {
    name: 'detailManage',
    components: {
        AModal: Modal,
        AFormItem: FormItem,
        AInput: Input,
        ADatePicker:DatePicker
    },
    setup(props) {
        const visible = ref(false);
        const record = ref(null);
        const SuaGiangVien = () => {
            axios.put(`https://localhost:7255/api/GiangVien/updateDataGV?magv=${formState.maGV}`,{
                maGV: formState.maGV,
                tenGV: formState.tenGV,
                diaChi: formState.diaChi,
                sdt: formState.sdt,
                email: formState.email,
                ngaySinh: formState.ngaySinh,
                gioiTinh: formState.gioiTinh 
            })
            .then(res => {
                notification.open({
                      message: 'Thông báo',
                      description:'sửa thông tin thành công',
                      onClick: () => {
                        console.log('Notification Clicked!');
                      },
                    });
                visible.value = false;
            })
            .catch(err => {
                notification.open({
                      message: 'Thông báo',
                      description:'sửa thông tin không thành công',
                      onClick: () => {
                        console.log('Notification Clicked!');
                      },
                    });
            })
        }
        const formState = reactive({
            maGV: null,
            tenGV: null,
            email: null,
            ngaySinh: null,
            diaChi: null,
            sdt: null,
            gioiTinh: null
        })
        const showModal = () => {
            visible.value = true;
        };
        // Hủy
        const handleCancel = () => {
            visible.value = false;
        };
        watch(record, (newValue, oldValue) => {
            if (newValue) {
                formState.maGV = newValue.maGV,
                    formState.tenGV = newValue.tenGV,
                    formState.diaChi = newValue.diaChi,
                    formState.sdt = newValue.sdt,
                    formState.email = newValue.email,
                    formState.ngaySinh = newValue.ngaySinh;
                    formState.gioiTinh = newValue.gioiTinh

            }

        });
        return {
            visible,
            formState,
            record,
            SuaGiangVien,
            showModal,
            handleCancel
        }
    }

}
</script>
  
<style></style>