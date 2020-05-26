call python xls_deploy_tool.py GOODS_INFO xls/goods_info.xls
call protoc tnt_deploy_goods_info.proto --descriptor_set_out=goods_info.protodesc
call ProtoGen\protogen -i:goods_info.protodesc -o:cs/goods_info.cs
@echo off
echo TRY TO DELETE TEMP FILES:
del *_pb2.py
del *_pb2.pyc
del *.proto
del *.log
del *.txt
del *.protodesc
pause