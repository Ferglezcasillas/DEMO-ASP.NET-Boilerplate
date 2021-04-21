import {
  Component,
  Injector,
  OnInit,
  EventEmitter,
  Output,
} from '@angular/core';
import { finalize } from 'rxjs/operators';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { forEach as _forEach, includes as _includes, map as _map } from 'lodash-es';
import { AppComponentBase } from '@shared/app-component-base';
import {
  ProductsServiceProxy,
  //GetProductForEditOutput,
  ProductDto,
  PermissionDto,
  //ProductEditDto,
  FlatPermissionDto
} from '@shared/service-proxies/service-proxies';

@Component({
  templateUrl: 'edit-product-dialog.component.html'
})
export class EditProductDialogComponent extends AppComponentBase
  implements OnInit {
  saving = false;
  id: number;
  product = new ProductDto();
  permissions: FlatPermissionDto[];
  grantedPermissionNames: string[];
  checkedPermissionsMap: { [key: string]: boolean } = {};

  @Output() onSave = new EventEmitter<any>();

  constructor(
    injector: Injector,
    private _productService: ProductsServiceProxy,
    public bsModalRef: BsModalRef
  ) {
    super(injector);
  }

  ngOnInit(): void {
    //console.log("ngOnInit:", this.id);
    this.product.id = this.id;
    // this._productService
    //   .getProductForEdit(this.id)
    //   .subscribe((result: GetProductForEditOutput) => {
    //     this.product = result.product;
    //     this.permissions = result.permissions;
    //     this.grantedPermissionNames = result.grantedPermissionNames;
    //     this.setInitialPermissionsStatus();
    //   });
  }

  setInitialPermissionsStatus(): void {
    _map(this.permissions, (item) => {
      this.checkedPermissionsMap[item.name] = this.isPermissionChecked(
        item.name
      );
    });
  }

  isPermissionChecked(permissionName: string): boolean {
    return _includes(this.grantedPermissionNames, permissionName);
  }

  onPermissionChange(permission: PermissionDto, $event) {
    this.checkedPermissionsMap[permission.name] = $event.target.checked;
  }

  getCheckedPermissions(): string[] {
    const permissions: string[] = [];
    _forEach(this.checkedPermissionsMap, function (value, key) {
      if (value) {
        permissions.push(key);
      }
    });
    return permissions;
  }

  save(): void {
    this.saving = true;

    const product = new ProductDto();
    product.init(this.product);
    //product.grantedPermissions = this.getCheckedPermissions();
    console.log(product);
    this._productService
      .update(product)
      .pipe(
        finalize(() => {
          this.saving = false;
        })
      )
      .subscribe(() => {
        this.notify.info(this.l('SavedSuccessfully'));
        this.bsModalRef.hide();
        this.onSave.emit();
      });
  }
}
