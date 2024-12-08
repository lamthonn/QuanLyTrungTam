<template>
    <a-modal v-model:open="visible" width="30%" title="Thêm thông báo mới" :centered="true" @ok="handleOk"
        class="addNewCourse">
        <div>
            <a-input addonBefore="Tiêu đề" v-model:value="formState.tieuDe" placeholder="Tiêu dề" allow-clear />
            <br />
            <br />
            <a-textarea v-model:value="formState.chiTiet" placeholder="Chi tiết thông báo" allow-clear :rows="4" />
            <a-radio-group v-model:value="formState.doiTuong" button-style="solid">
                <a-radio-button value="Học Viên">Học viên</a-radio-button>
                <a-radio-button value="Giảng Viên">Giảng viên</a-radio-button>
            </a-radio-group>
        </div>

    </a-modal>
</template>
  
<script>
import { reactive, ref } from 'vue';
import { Modal, FormItem, Input, Textarea, RadioGroup, RadioButton } from 'ant-design-vue/es/components'
import { notification } from 'ant-design-vue';
import axios from 'axios';
export default {
    name: 'AddNotice',
    components: {
        AModal: Modal,
        AFormItem: FormItem,
        AInput: Input,
        ATextarea: Textarea,
        ARadioGroup: RadioGroup,
        ARadioButton: RadioButton
    },
    setup() {
        const visible = ref(false);
        const handleOk = () => {
            axios.post("https://localhost:7255/api/ThongBao/AddThongBao", {
                id: 0,
                title: formState.tieuDe,
                description: formState.chiTiet,
                doiTuong: formState.doiTuong
            })
                .then(res => {
                    notification.open({
                        message: 'Thông báo',
                        description: 'Thêm thông báo thành công',
                        onClick: () => {
                            console.log('Notification Clicked!');
                        },
                    });
                    visible.value = false
                }).catch(er => {
                    notification.open({
                        message: 'Thông báo',
                        description: 'Thêm thông báo không thành công',
                        onClick: () => {
                            console.log('Notification Clicked!');
                        },
                    });
                })
        }
        const formState = reactive({
            tieuDe: null,
            chiTiet: null,
            doiTuong: null
        })
        return {
            visible,
            formState,
            handleOk
        }
    }

}
</script>
  
<style></style>