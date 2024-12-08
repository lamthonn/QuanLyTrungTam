<template>
    <a-modal v-model:open="visible" width="40%" :centered="true" @ok="handleOk" class="addNewCourse">
        <h2 class="rowCourse tittle-AddCourse">SỬA KHÓA HỌC</h2>
        <div class="rowCourse idCourse">
            <input class="inputCourse" type="maKH" id="mã khóa học" name="makH" v-model="formState.maKH" disabled
                placeholder="Nhập mã khóa học" required>
        </div>
        <div class="rowCourse nameCourse">
            <input class="inputCourse" type="name" v-model="formState.tenKH" placeholder="Nhập tên khóa học" required>
        </div>

        <div class="rowCourse desCourse">
            <input class="inputCourse" type="description" v-model="formState.description" placeholder="Mô tả khóa học"
                required>
        </div>

        <div class="rowCourse priceCourse">
            <input class="inputCourse" type="price" v-model="formState.price" placeholder="Nhập giá khóa học" required>
        </div>
        <div class="rowCourse ageCourse">
            <input class="inputCourse" type="luaTuoi" v-model="formState.luaTuoi" placeholder="Nhập lứa tuổi của khóa học"
                required>
        </div>
        <div class="rowCourse typeCourse">
            <input class="inputCourse" type="loai" v-model="formState.loai" placeholder="Nhập loại khóa học" required>
        </div>
        <div class="rowCourse maGVCourse">
            <input class="inputCourse" type="maGV" v-model="formState.maGV" placeholder="Nhập mã giáo viên khóa học"
                required>
        </div>
    </a-modal>
</template>

<script>
import { reactive, ref, watch } from 'vue';
import { Modal, FormItem, Input, Upload, notification } from 'ant-design-vue/es/components'
import { PlusOutlined } from '@ant-design/icons-vue';
import axios from 'axios';
export default {
    name: "AddNewCourse-",
    components: {
        AModal: Modal,
        AFormItem: FormItem,
        AInput: Input,
        AUpload: Upload,

        PlusOutlined,
    },
    setup() {
        const visible = ref(false);
        const record = ref()
        const formState = reactive({
            maKH: null,
            tenKH: null,
            description: null,
            price: null,
            rate: null,
            luaTuoi: null,
            loai: null,
            maGV: null
        })
        const handleOk = () => {
            axios.put(`https://localhost:7255/api/KhoaHoc/${formState.maKH}`, {
                maKH: formState.maKH,
                tenKH: formState.tenKH,
                description: formState.description,
                price: formState.price,
                rate: formState.rate,
                luaTuoi: formState.luaTuoi,
                loai: formState.loai,
                pathImage: '',
                maGV: formState.maGV
            })
            .then(res => {
                notification.open({
                    message: 'Thông báo',
                    description: 'Sửa thông tin khóa học thành công',
                    onClick: () => {
                        console.log('Notification Clicked!');
                    },
                });
                visible.value = false
            })
            .catch(err => {
                notification.open({
                    message: 'Thông báo',
                    description: 'Sửa thông tin khóa học không thành công',
                    onClick: () => {
                        console.log('Notification Clicked!');
                    },
                });
            });
        }

        watch(record, (newVal) => {
            if (newVal) {
                formState.maKH = newVal.maKH;
                formState.tenKH = newVal.tenKH;
                formState.description = newVal.description;
                formState.price = newVal.price;
                formState.rate = newVal.rate;
                formState.luaTuoi = newVal.luaTuoi;
                formState.loai = newVal.loai;
                formState.maGV = newVal.maGV;
            }
        })
        return {
            visible,
            record,
            formState,
            handleOk,
        }
    }
}
</script>

<style>
.ant-modal.css-dev-only-do-not-override-kqecok.addNewCourse {
    width: auto !important;
}

.inputCourse {
    position: relative;
    width: 100%;
    height: 40px;
    border-radius: 20px;
    padding: 0 20px;
}


h2.rowCourse.tittle-AddCourse {
    text-align: center;
    font-weight: bold;
    color: #2e8457;
}

.rowCourse {
    margin-bottom: 15px;
}
</style>