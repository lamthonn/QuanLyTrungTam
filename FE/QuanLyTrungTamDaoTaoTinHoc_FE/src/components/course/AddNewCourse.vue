<template>
    <a-modal v-model:open="visible" width="40%" :centered="true" @ok="handleOk" class="addNewCourse">
       <h2 class="rowCourse tittle-AddCourse">THÊM KHÓA HỌC</h2>
       <div class="rowCourse idCourse">
           <input class ="inputCourse" type="maKH" id="mã khóa học" name="makH" v-model="maKH" placeholder="Nhập mã khóa học" required>
       </div>
       <div class="rowCourse nameCourse">
           <input class ="inputCourse" type="name" v-model="tenKH" placeholder="Nhập tên khóa học" required>
       </div>

       <div class="rowCourse desCourse">
           <input class ="inputCourse" type="description" v-model="description" placeholder="Mô tả khóa học" required>
       </div>

       <div class="rowCourse priceCourse">
           <input class ="inputCourse" type="price" v-model="price" placeholder="Nhập giá khóa học" required>
       </div>
       <div class="rowCourse ageCourse">
           <input class ="inputCourse" type="luaTuoi" v-model="luaTuoi" placeholder="Nhập lứa tuổi của khóa học" required>
       </div>
       <div class="rowCourse typeCourse">
           <input class ="inputCourse" type="loai" v-model="loai" placeholder="Nhập loại khóa học" required>
       </div>
       <div class="rowCourse maGVCourse">
           <input class ="inputCourse" type="maGV" v-model="maGV" placeholder="Nhập mã giáo viên khóa học" required>
       </div>
       <a-form-item label="Tải ảnh background">
           <a-upload list-type="picture-card" :max-count="1">
               <div>
                   <PlusOutlined />
               <div style="margin-top: 8px">Upload</div>
               </div>
           </a-upload>
       </a-form-item>
   </a-modal>
</template>

<script>
import { ref } from 'vue';
import { Modal,FormItem, Input,Upload, notification  } from 'ant-design-vue/es/components'
import { PlusOutlined } from '@ant-design/icons-vue';
export default{
   name: "AddNewCourse-",
   components:{
       AModal:Modal,
       AFormItem:FormItem,
       AInput:Input,
       AUpload:Upload,

       PlusOutlined,
   },
   setup(){
       const maKH = ref('');
       const tenKH = ref('');
       const description = ref('');
       const price = ref('');
       const rate = ref('');
       const luaTuoi = ref('');
       const loai = ref('');
       const pathImage = ref('');
       const maGV = ref('');
       const visible = ref(false);
       const resetData=()=>{
           maKH.value = ''
           tenKH.value = ''
           description.value = ''
           price.value = ''
           rate.value = ''
           luaTuoi.value = ''
           loai.value = ''
           pathImage.value = ''
           maGV.value = ''
        //    visible.value = ''

        }
       const handleOk= () => {
           if(maKH.value === ''){
               notification.open({
                    message: 'Chưa nhập Mã khóa học!',
                    onClick: () => {
                        console.log('Notification Clicked!');
                    },
                });
           }
           else if(tenKH.value === ''){
            //    alert("Chưa nhập Tên khóa học!")
               notification.open({
                    message: 'Chưa nhập Tên khóa học!',
                    onClick: () => {
                        console.log('Notification Clicked!');
                    },
                });
           }
           else if(description.value === ''){
            //    alert("Chưa nhập Mô tả khóa học!")
               notification.open({
                    message: 'Chưa nhập Mô tả khóa học!',
                    onClick: () => {
                        console.log('Notification Clicked!');
                    },
                });
           }
           else if(price.value === ''){
            //    alert("Chưa nhập Giá khóa học!")
               notification.open({
                    message: 'Chưa nhập Giá khóa học!',
                    onClick: () => {
                        console.log('Notification Clicked!');
                    },
                });
           }
           else if(rate.value === ''){
            //    alert("Chưa nhập Đánh giá ban đầu khóa học!")
            notification.open({
                    message: 'Chưa nhập Đánh giá ban đầu khóa học!',
                    onClick: () => {
                        console.log('Notification Clicked!');
                    },
                });
           }
           else if(luaTuoi.value === ''){
            //    alert("Chưa nhập Lứa tuổi khóa học!")
            notification.open({
                    message: 'Chưa nhập Lứa tuổi khóa học!',
                    onClick: () => {
                        console.log('Notification Clicked!');
                    },
                });
           }
           else if(loai.value === ''){
            //    alert("Chưa nhập Loại khóa học!")
            notification.open({
                    message: 'Chưa nhập Loại khóa học!',
                    onClick: () => {
                        console.log('Notification Clicked!');
                    },
                });
           }
           else if(pathImage.value === ''){
            //    alert("Chưa nhập Đường link ảnh khóa học!")
               notification.open({
                    message: 'Chưa tải ảnh khóa học!',
                    onClick: () => {
                        console.log('Notification Clicked!');
                    },
                });
           }
           else if(maGV.value === ''){
            //    alert("Chưa nhập Mã giáo viên khóa học!")
            notification.open({
                    message: 'Chưa nhập Mã giáo viên khóa học!',
                    onClick: () => {
                        console.log('Notification Clicked!');
                    },
                });
           }
           else{
               store.dispatch('addNewCourse',{
                   "maKH": maKH.value,
                   "tenKH": tenKH.value,
                   "description": description.value,
                   "price":price.value,
                   "rate":rate.value,
                   "luaTuoi": luaTuoi.value,
                   "loai": loai.value,
                   "pathImage": pathImage.value,
                   "maGV": maGV.value,
               })
           }
       }

       return{
           visible,
           maKH,
           tenKH,
           description,
           price,
           rate,
           luaTuoi,
           loai,
           pathImage,
           maGV,
           handleOk,
       }
   }
}
</script>

<style>
.ant-modal.css-dev-only-do-not-override-kqecok.addNewCourse {
   width: auto  !important;
}

.inputCourse {
   position: relative;
   width: 100%;
   height: 40px;
   border-radius: 20px;
   padding: 0 20px;
}


h2.rowCourse.tittle-AddCourse {
   TEXT-ALIGN: center;
   font-weight: bold;
   color: #2e8457;
}
/* .ant-modal-content {
   width: 600px;
} */

.rowCourse{
   margin-bottom: 15px;
}
</style>