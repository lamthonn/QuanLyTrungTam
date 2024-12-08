<template>
    <a-modal v-model:open="visible" width="40%" title="Sửa thông tin học viên" :centered="true" @ok="SuaHocVien"
        class="addNewCourse">
        <div>
            <a-form-item>
                <a-input addonBefore="Mã học viên" v-model:value="formState.maHV" disabled placeholder="Mã học viên" allow-clear />
            </a-form-item>
            <a-form-item>
                <a-input addonBefore="Tên học viên" v-model:value="formState.tenHV" placeholder="Tên học viên" allow-clear />
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
        const SuaHocVien = () => {
            axios.put(`https://localhost:7255/api/HocVien/Update/${formState.maHV}`,{
                maHV: formState.maHV,
                tenHV: formState.tenHV,
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
            maHV: null,
            tenHV: null,
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
                formState.maHV = newValue.maHV,
                    formState.tenHV = newValue.tenHV,
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
            SuaHocVien,
            showModal,
            handleCancel
        }
    }

}
</script>
  
<style></style>